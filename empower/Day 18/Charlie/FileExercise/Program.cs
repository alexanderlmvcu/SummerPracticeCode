using System;
using System.IO;
using Newtonsoft.Json;


namespace FileExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var productShirt = new StoreProducts()
            {
                ProductName = "Women's Scoop Neck Blouse",
                Price = 16,
                OnSale = false,
                NewArrival = true,
                ProductType = "Blouse",
                Quantity = 30,
                Color = "White",
                Brand = "Clean Air"
            };
            var productJson = JsonConvert.SerializeObject(productShirt);
            var path = @"C:\MyFiles\Product1Json.txt";
            File.WriteAllText(path, productJson);

            var read = File.ReadAllText(path);
            var products2 = JsonConvert.DeserializeObject<StoreProducts>(read);

            var productPants = new StoreProducts()
            {
                ProductName = "Women's Bow Tie Long Pants",
                Price = 8,
                OnSale = true,
                NewArrival = false,
                ProductType = "Pants",
                Quantity = 12,
                Color = "Mauve",
                Brand = "Modern Chic"
            };
            var product2Json = JsonConvert.SerializeObject(productPants);
            var path2 = @"C:\MyFiles\Product2Json.txt";
            File.WriteAllText(path2, product2Json);

            var read2 = File.ReadAllText(path2);
            var products21 = JsonConvert.DeserializeObject<StoreProducts>(read2);
            // Proposed Exercise:
            //  Use a file system folder as a database.
            //  Create any class you wish (such as Pet), and write many "records", where a single
            //   record is a single file in the folder.
            //  Create methods in your application to read and write those classes (in JSON shape).
            //  Use LINQ to perform queries over objects that are being read from the operating system.
            //  Be creative!
        }
    }
}
