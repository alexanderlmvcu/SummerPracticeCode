using System;
using System.IO;

namespace DataStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\MyFiles\101.txt";
            string allText;
            using (var stream = new FileStream(path, FileMode.Open))
            {
                using (var reader = new StreamReader(stream))
                {
                    while(!reader.EndOfStream)
                    {
                        Console.WriteLine(reader.Read());
                    }
                    //allText = reader.ReadToEnd();
                }
            }
            //Console.WriteLine(allText);
            Console.ReadKey();

        }
        static void Example3()
        { 
          var database = new FileSystemDatabase(@"C:\\MyFiles");
          database.Create(new Pet()
          {
              Id = 101,
              Name = "Loretta",
              Age = 5,
              IsSpotted = true,
              Color = "Brown"
          });

          var loretta = database.Read(101);
        }
    }
}
