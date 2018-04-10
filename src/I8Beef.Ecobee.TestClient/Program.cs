using I8Beef.Ecobee.Protocol.Thermostat;
using System;
using System.IO;
using System.Text;

namespace I8Beef.Ecobee.TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var appKey = "";
            StoredAuthToken storedAuthToken;          

            if (File.Exists(@"token.txt"))
            {
                Console.WriteLine("Reading cached tokens");
                var tokenText = File.ReadAllLines(@"token.txt");

                storedAuthToken = new StoredAuthToken
                {
                    TokenExpiration = DateTime.Parse(tokenText[0]),
                    AuthToken = tokenText[1],
                    RefreshToken = tokenText[2]
                };
            }
            else
            {
                Console.WriteLine("Getting new tokens");
                var pin = Client.GetPinAsync(appKey).Result;

                Console.WriteLine("Pin: " + pin.EcobeePin);
                Console.WriteLine("You have " + pin.ExpiresIn + " minutes to enter this on the Ecobee site.");

                Console.ReadLine();

                storedAuthToken = Client.GetAccessTokenAsync(appKey, pin.Code).Result;
                WriteTokenFile(storedAuthToken);
            }

            Console.WriteLine("Access Token: " + storedAuthToken.AuthToken);
            Console.WriteLine("Refresh Token: " + storedAuthToken.RefreshToken);
            Console.WriteLine("Hold onto these");

            // Setup client
            var client = new Client(appKey, storedAuthToken, (o) => { WriteTokenFile(o); });

            Console.WriteLine("Getting thermostat information");

            var request = new ThermostatSummaryRequest
            {
                Selection = new Protocol.Objects.Selection
                {
                    SelectionType = "registered"
                }
            };

            var response = client.GetAsync<ThermostatSummaryRequest, ThermostatSummaryResponse>(request).Result;

            Console.WriteLine();
            Console.WriteLine(JsonSerializer<ThermostatSummaryResponse>.Serialize(response));

            Console.ReadLine();
        }

        public static void WriteTokenFile(StoredAuthToken storedAuthToken)
        {
            var text = new StringBuilder();
            text.AppendLine($"{storedAuthToken.TokenExpiration:MM/dd/yy hh:mm:ss tt}");
            text.AppendLine(storedAuthToken.AuthToken);
            text.AppendLine(storedAuthToken.RefreshToken);

            // Cache the returned tokens
            File.WriteAllText(@"token.txt", text.ToString());
        }
    }
}
