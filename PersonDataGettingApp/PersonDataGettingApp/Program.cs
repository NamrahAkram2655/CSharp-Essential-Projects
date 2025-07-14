using System.Text.Json;

namespace PersonJsonApp
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            List<Person> people = new List<Person>
            {
                new Person { Name = "Alice", Age = 25, Email = "alice@example.com" },
                new Person { Name = "Bob", Age = 30, Email = "bob@example.com" },
                new Person { Name = "Charlie", Age = 22, Email = "charlie@example.com" },
                new Person { Name = "Diana", Age = 28, Email = "diana@example.com" },
                new Person { Name = "Ethan", Age = 35, Email = "ethan@example.com" }
            };

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(people, options);

            File.WriteAllText("data.json", jsonString);
            //string filePath = Path.GetFullPath("data.json");
            //Console.WriteLine("Data saved to: " + filePath);

            Console.WriteLine("Data has been written to data.json successfully.");
        }
    }
}
