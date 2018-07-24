using System;
using System.Data.SqlClient;
using System.Net.Http;
using System.Data;

namespace ConsoleAppGoogleEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //var client = new HttpClient();
            //var task = client.GetStringAsync("http://github.com");
            //task.Wait();
            //var result = task.Result;
            

            var connectionString = "Server=.\\S2017E;Database=PetsDatabase;Trusted_Connection=true;";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "GetAllSpottedPets";
                    command.CommandType = CommandType.StoredProcedure;
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader.GetString(1));
                            
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
