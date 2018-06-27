using System;
using System.IO;
using Newtonsoft.Json;

namespace Charlie
{
    class Program
    {
        static void Main(string[] args)
        {
            var pet = new Pet()
            {
                Name = "Loretta",
                Age = 5,
                IsSpotted = true,
                Color = "Brown"
            };
            var petJson = JsonConvert.SerializeObject(pet);
            var path = @"C:\MyFiles\LorettaJson.txt";
            File.WriteAllText(path, petJson);
            var read = File.ReadAllText(path);
            var pet2 = JsonConvert.DeserializeObject<Pet>(read);
        }
        static void Example1()
        {
           ////var name = "Linda";
           // var fileName = "Jeff.txt";
           // var path = "C:\\MyFiles\\" + fileName;
           // if (File.Exists(path))
           // {
           //     var read = File.ReadAllText(path);
           //  }
           // else
           // {
           //     File.WriteAllText(path, String.Empty);
           // }
           // File.Copy(path, path.Replace("Jeff", "Adam"));
           // Console.ReadKey();
        }
    }

    internal class Pet
    {
        public Pet()
        {
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsSpotted { get; set; }
        public string Color { get; set; }
    }
}
