using System.Net.Http;
using System.Threading.Tasks;

public class JsonHelper
{
    private static readonly HttpClient client = new HttpClient();

    public static async Task<string> GetJsonAsync(string url)
    {
        try
        {
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
        catch (HttpRequestException ex)
        {
            return null;
        }
    }
}