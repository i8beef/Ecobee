using I8Beef.Ecobee.Messages;
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
            var accessToken = "";
            var refreshToken = "";
            var tokenExpiration = DateTime.Now;

            if (File.Exists(@"token.txt"))
            {
                Console.WriteLine("Reading cached tokens");
                var tokenText = File.ReadAllLines(@"token.txt");

                tokenExpiration = DateTime.Parse(tokenText[0]);
                accessToken = tokenText[1];
                refreshToken = tokenText[2];
            }
            else
            {
                Console.WriteLine("Getting new tokens");
                var pin = Client.GetPin(appKey).Result;

                Console.WriteLine("Pin: " + pin.EcobeePin);
                Console.WriteLine("You have " + pin.ExpiresIn + " minutes to enter this on the Ecobee site.");

                Console.ReadLine();

                var authToken = Client.GetAccessToken(appKey, pin.Code).Result;
                WriteTokenFile(authToken);

                accessToken = authToken.AccessToken;
                refreshToken = authToken.RefreshToken;
                tokenExpiration = DateTime.Now.AddSeconds(authToken.ExpiresIn);
            }

            Console.WriteLine("Access Token: " + accessToken);
            Console.WriteLine("Refresh Token: " + refreshToken);
            Console.WriteLine("Hold onto these");

            // Setup client
            var client = new Client(appKey, accessToken, refreshToken, tokenExpiration);
            client.AuthTokenUpdated += (o, e) =>
            {
                WriteTokenFile(e);
            };

            Console.WriteLine("Getting thermostat information");

            var request = new ThermostatSummaryRequest
            {
                Selection = new Protocol.Objects.Selection
                {
                    SelectionType = "registered"
                }
            };

            var response = client.Get<ThermostatSummaryRequest, ThermostatSummaryResponse>(request).Result;

            Console.WriteLine();
            Console.WriteLine(JsonSerializer<ThermostatSummaryResponse>.Serialize(response));

            Console.ReadLine();
        }

        public static void WriteTokenFile(AuthToken token)
        {
            var text = new StringBuilder();
            text.AppendLine(DateTime.Now.AddSeconds(token.ExpiresIn).ToString());
            text.AppendLine(token.AccessToken);
            text.AppendLine(token.RefreshToken);

            // Cache the returned tokens
            File.WriteAllText(@"token.txt", text.ToString());
        }
    }
}
