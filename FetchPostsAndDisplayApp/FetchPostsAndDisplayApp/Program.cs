using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;

class Program
{
    static async Task Main(string[] args)
    {
        string url = "https://jsonplaceholder.typicode.com/posts";
        HttpClient client = new HttpClient();

        try
        {
            // Send HTTP GET request
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode(); // Throw if not success

            // Read response content as a string
            string jsonData = await response.Content.ReadAsStringAsync();

            // Save to file
            File.WriteAllText("data.json", jsonData);
            Console.WriteLine("Data saved to data.json");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
