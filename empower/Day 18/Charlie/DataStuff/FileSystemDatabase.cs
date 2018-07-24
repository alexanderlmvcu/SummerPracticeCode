using System;
using System.IO;
using Newtonsoft.Json;

namespace DataStuff
{
    public class FileSystemDatabase : IDatabase
    {
        private readonly string rootPath;

        public FileSystemDatabase (string path)
        {
            rootPath = path;
        }

        public void Create(Pet pet)
        {
            var petJson = JsonConvert.SerializeObject(pet);
            var fileName = GenerateFileName(pet.Id);
            File.WriteAllText(GetFullPath(fileName), petJson);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Pet Read(int id)
        {
            var fileName = GenerateFileName(id);
            var text = File.ReadAllText(GetFullPath(fileName));
            return JsonConvert.DeserializeObject<Pet>(text);
            throw new NotImplementedException();
        }

        public void Update(Pet pet)
        {
            throw new NotImplementedException();
        }
        private string GenerateFileName(int id)
        {
            return id.ToString() + ".txt";
        }
        private string GetFullPath(string fileName)
        {
            return rootPath + "\\" + fileName; 
        }
    }
}
