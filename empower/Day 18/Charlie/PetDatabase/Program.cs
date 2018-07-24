using System;
using System.IO;

namespace PetDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            var database = new SQLDatabase("Server=.\\S2017E;Database=PetsDatabase;Trusted_Connection=True;");
            //var pet = new Pet()
            //{
            //    Name = "Jeff",
            //    Age = 2,
            //    IsSpotted = false,
            //    Color = "brown and white"
            //};
           // AddPet(database, pet);

            //var pet = database.Read(1);
            foreach (var pet in database.GetAllPets())
            {
                Console.WriteLine($"This pet is {pet.Name} and is {pet.Age} years old.");
            }
            Console.ReadKey();

        }
        static void AddPet(IDatabase database, Pet pet)
        {
            database.Create(pet);
        }
        static void Example3()
        {
            var database = new FileSystemDatabase(@"C:\MyFiles");
            //database.Create(new Pet()
            //{
            //    Id = 101,
            //    Name = "Loretta",
            //    Age = 5,
            //    IsSpotted = true,
            //    Color = "Brown"
            //});


            var loretta = database.Read(101);
        }
    }
}
