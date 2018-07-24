using System;
using System.Collections.Generic;
using System.Text;

namespace DataStuff
{
    interface IDatabase
    {
        void Create(Pet pet);
        Pet Read(int id);
        void Update(Pet pet);
        void Delete(int id);
    }
}
