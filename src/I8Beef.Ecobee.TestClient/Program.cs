using I8Beef.Ecobee.Messages;
using I8Beef.Ecobee.Protocol;
using I8Beef.Ecobee.Protocol.Thermostat;
using System;
using System.Collections.Generic;
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
                var pin = Client.GetPinAsync(appKey).Result;

                Console.WriteLine("Pin: " + pin.EcobeePin);
                Console.WriteLine("You have " + pin.ExpiresIn + " minutes to enter this on the Ecobee site.");

                Console.ReadLine();

                var authToken = Client.GetAccessTokenAsync(appKey, pin.Code).Result;
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
                WriteTokenFile(e.AuthToken);
            };

            // Get thermostat summary
            Console.WriteLine("Getting thermostat summary");

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

            //var updateResponse = client.PostAsync<ThermostatUpdateRequest, Response>(updateRequest).Result;
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

            //var thermoResponse = client.GetAsync<ThermostatRequest, ThermostatResponse>(theroRequest).Result;
            //Console.WriteLine();
            //Console.WriteLine(JsonSerializer<ThermostatResponse>.Serialize(thermoResponse));

            //
            Console.WriteLine("Setting thermostat fan hold");

            var themroFanRequest = new ThermostatUpdateRequest
            {
                Selection = new Protocol.Objects.Selection
                {
                    SelectionType = "registered"
                },
                Functions = new List<Protocol.Objects.Function>
                {
                    new Protocol.Functions.SetHoldFunction
                    {
                        Params = new Protocol.Functions.SetHoldParams
                        {
                            HoldType = "nextTransition",
                            Fan = "on"
                        }
                    }
                }
            };

            var themroFanResponse = client.PostAsync<ThermostatUpdateRequest, Response>(themroFanRequest).Result;
            Console.WriteLine();
            Console.WriteLine(JsonSerializer<Response>.Serialize(themroFanResponse));

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
