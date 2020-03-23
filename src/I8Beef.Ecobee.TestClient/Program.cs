using I8Beef.Ecobee.Protocol.Thermostat;
using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace I8Beef.Ecobee.TestClient
{
    class Program
    {
        private static StoredAuthToken _currentAuthToken;

        private static async Task Main()
        {
            // Setup client
            var appKey = "";
            var client = new Client(appKey, ReadTokenFileAsync, WriteTokenFileAsync);

            if (!File.Exists(@"token.txt"))
            {
                Console.WriteLine("Getting new tokens");
                var pin = await client.GetPinAsync();

                Console.WriteLine("Pin: " + pin.EcobeePin);
                Console.WriteLine("You have " + pin.ExpiresIn + " minutes to enter this on the Ecobee site and hit enter.");

                Console.ReadLine();

                await client.GetAccessTokenAsync(pin.Code);
            }
            else
            {
                Console.WriteLine("Loading existing tokens");
                var storedAuthToken = await ReadTokenFileAsync();
            }

            Console.WriteLine("Access Token: " + _currentAuthToken.AccessToken);
            Console.WriteLine("Refresh Token: " + _currentAuthToken.RefreshToken);
            Console.WriteLine("Hold onto these");

            // Get thermostat summary
            Console.WriteLine("Getting thermostat summary");

            var request = new ThermostatSummaryRequest
            {
                Selection = new Protocol.Objects.Selection
                {
                    SelectionType = "registered"
                }
            };

            var response = await client.GetAsync<ThermostatSummaryRequest, ThermostatSummaryResponse>(request);
            Console.WriteLine();
            Console.WriteLine(JsonSerializer<ThermostatSummaryResponse>.Serialize(response));

            // Set the HvacMode
            //Console.WriteLine("Setting thermostat HVAC mode");

            //var updateRequest = new ThermostatUpdateRequest
            //{
            //    Selection = new Protocol.Objects.Selection
            //    {
            //        SelectionType = "registered"
            //    },
            //    Thermostat = new { Settings = new { HvacMode = "auto" } }
            //};

            //var updateResponse = await client.PostAsync<ThermostatUpdateRequest, Response>(updateRequest);
            //Console.WriteLine();
            //Console.WriteLine(JsonSerializer<Response>.Serialize(updateResponse));

            // Get thermostat settings
            //Console.WriteLine("Getting thermostat information");

            //var theroRequest = new ThermostatRequest
            //{
            //    Selection = new Protocol.Objects.Selection
            //    {
            //        SelectionType = "registered",
            //        IncludeSettings = true
            //    }
            //};

            //var thermoResponse = await client.GetAsync<ThermostatRequest, ThermostatResponse>(theroRequest);
            //Console.WriteLine();
            //Console.WriteLine(JsonSerializer<ThermostatResponse>.Serialize(thermoResponse));

            // Set thermostat fan
            //Console.WriteLine("Setting thermostat fan hold");

            //var themroFanRequest = new ThermostatUpdateRequest
            //{
            //    Selection = new Protocol.Objects.Selection
            //    {
            //        SelectionType = "registered"
            //    },
            //    Functions = new List<Protocol.Objects.Function>
            //    {
            //        new Protocol.Functions.SetHoldFunction
            //        {
            //            Params = new Protocol.Functions.SetHoldParams
            //            {
            //                HoldType = "nextTransition",
            //                Fan = "on"
            //            }
            //        }
            //    }
            //};

            //var themroFanResponse = await client.PostAsync<ThermostatUpdateRequest, Response>(themroFanRequest);
            //Console.WriteLine();
            //Console.WriteLine(JsonSerializer<Response>.Serialize(themroFanResponse));

            Console.ReadLine();
        }

        public static async Task WriteTokenFileAsync(StoredAuthToken storedAuthToken, CancellationToken cancellationToken = default)
        {
            // Cache the returned tokens
            _currentAuthToken = storedAuthToken;

            // Write token to persistent store
            var text = new StringBuilder();
            text.AppendLine($"{storedAuthToken.TokenExpiration:MM/dd/yy hh:mm:ss tt}");
            text.AppendLine(storedAuthToken.AccessToken);
            text.AppendLine(storedAuthToken.RefreshToken);

            await File.WriteAllTextAsync(@"token.txt", text.ToString());
        }

        public static async Task<StoredAuthToken> ReadTokenFileAsync(CancellationToken cancellationToken = default)
        {
            if (_currentAuthToken == null && File.Exists(@"token.txt"))
            {
                var tokenText = await File.ReadAllLinesAsync(@"token.txt");
                _currentAuthToken = new StoredAuthToken
                {
                    TokenExpiration = DateTime.Parse(tokenText[0]),
                    AccessToken = tokenText[1],
                    RefreshToken = tokenText[2]
                };
            }

            return _currentAuthToken;
        }
    }
}
