using System;
using System.Collections.Generic;

namespace Delta18
{
    interface IDatabase
    {
        void Create(Pet pet);
        Pet Read(int id);
        void Update(Pet pet);
        void Delete(int id);
        IEnumerable<Pet> GetAllPets();
    }
}
