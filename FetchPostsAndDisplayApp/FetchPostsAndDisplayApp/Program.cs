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
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode(); 

            string jsonData = await response.Content.ReadAsStringAsync();

            File.WriteAllText("data.json", jsonData);
            Console.WriteLine("Data saved to data.json");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
