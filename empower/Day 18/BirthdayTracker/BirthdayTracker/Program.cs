using System;
using System.Linq;
using System.Data.SqlClient;
using System.Configuration;

namespace BirthdayTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["BirthdayConnectionString"].ConnectionString;
            var database = new BirthdayDatabase("");
            //database.Create(new Location() { LocationName = "My House" });

            var allLocations = database.GetAllLocations().ToArray();

            foreach(var location in allLocations)
            {
                Console.WriteLine($"{location.LocationId}\t {location.LocationName}");
            }

            var availableLocations = allLocations
                .Where(location => location.IsAvailable.HasValue && l.IsAvailable.Value)
                .OrderBy(location => location.LocationName)
                .ToArray();

            Console.WriteLine("Hello World!");
        }
    }
}
