using System;
using System.Net.Http;
using System.IO;
using System.Text.Json;
namespace WebApp2.Controller.Services
{
    public class LocationService
    {
        private readonly HttpClient _httpClient;

        public LocationService(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<Location> GetNearestWaterLocation(Location location)
        {
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "C# App");
            var x = await _httpClient.GetAsync($"https://nominatim.openstreetmap.org/reverse.php?lat={location.Latitude}&lon={location.Longitude}&zoom=18&format=jsonv2");
            var JsonObjectString = await x.Content.ReadAsStringAsync();
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "location.json");
            File.WriteAllText(filePath, JsonObjectString);
            string newJsonObject = File.ReadAllText(filePath);



            location = JsonSerializer.Deserialize<Location>(newJsonObject);

            //string newJsonObject = File.ReadAllText(filePath);

            return location;

            // we get lat and long from user
            // we need to serialise the response from the post request so that we can make a get request through our API
        }
    }
}