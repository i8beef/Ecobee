using System;

namespace Ecobee.TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var appKey = "";
            var pin = Client.GetPin(appKey).Result;

            Console.WriteLine("Pin: " + pin.EcobeePin);
            Console.WriteLine("You have " + pin.ExpiresIn + " minutes to enter this on the Ecobee site.");

            Console.ReadLine();

            var authToken = Client.GetAccessToken(appKey, pin.Code).Result;

            Console.WriteLine("Access Token: " + authToken.AccessToken);
            Console.WriteLine("Refresh Token: " + authToken.RefreshToken);
            Console.WriteLine("Hold onto these");

            var client = new Client(appKey, authToken.AccessToken, authToken.RefreshToken);

            // Now I can send stuff

            Console.ReadLine();
        }
    }
}
