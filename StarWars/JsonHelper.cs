using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace StarWars
{
    // Helper class used to handle all API requests to SWAPI
    public class JsonHelper
    {
        // Single HttpClient instance (best practice)
        private static readonly HttpClient client = new HttpClient();

        // Sends a GET request and returns JSON string result
        public static async Task<string> GetJsonAsync(string url)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);

                // Throws exception if request fails (404, 500, etc.)
                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException ex)
            {
                // Optional: log or debug message
                Console.WriteLine($"API Error: {ex.Message}");

                return null; // indicates failed request
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
                return null;
            }
        }
    }
}