using Google.Apis.Services;
using Google.Apis.Http;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class ContractorRequest
{
       
    public async Task GetPlace()
    {
        string apiKey = "api_key";
        string query = "contractors near me";
        string apiUrl = $"https://maps.googleapis.com/maps/api/place/textsearch/json?query={Uri.EscapeDataString(query)}&key={apiKey}";
        using HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync(apiUrl);

        if (response.IsSuccessStatusCode)
        {
            string result = await response.Content.ReadAsStringAsync();
            // Console.WriteLine("Response from API: " + result);
            // File.WriteAllText("response.txt", result);
            // string json = JsonSerializer.Serialize(result);
            // Console.WriteLine(json);
            File.WriteAllText("response.json", result);
            // return result;
        }
        else
        {
            Console.WriteLine("Error: " + response.StatusCode);
            // return null;
        }
    }
}