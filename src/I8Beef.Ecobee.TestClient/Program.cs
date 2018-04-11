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
            StoredAuthToken storedAuthToken;

            if (File.Exists(@"token.txt"))
            {
                Console.WriteLine("Reading cached tokens");
                var tokenText = File.ReadAllLines(@"token.txt");

                storedAuthToken = new StoredAuthToken
                {
                    TokenExpiration = DateTime.Parse(tokenText[0]),
                    AccessToken = tokenText[1],
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

            Console.WriteLine("Access Token: " + storedAuthToken.AccessToken);
            Console.WriteLine("Refresh Token: " + storedAuthToken.RefreshToken);
            Console.WriteLine("Hold onto these");

            // Setup client
            var client = new Client(appKey, storedAuthToken, async (authToken, cancellationToken) => { WriteTokenFile(authToken); });

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

            //var themroFanResponse = client.PostAsync<ThermostatUpdateRequest, Response>(themroFanRequest).Result;
            //Console.WriteLine();
            //Console.WriteLine(JsonSerializer<Response>.Serialize(themroFanResponse));

            Console.ReadLine();
        }

        public static void WriteTokenFile(StoredAuthToken storedAuthToken)
        {
            var text = new StringBuilder();
            text.AppendLine($"{storedAuthToken.TokenExpiration:MM/dd/yy hh:mm:ss tt}");
            text.AppendLine(storedAuthToken.AccessToken);
            text.AppendLine(storedAuthToken.RefreshToken);

            // Cache the returned tokens
            File.WriteAllText(@"token.txt", text.ToString());
        }        
    }
}
