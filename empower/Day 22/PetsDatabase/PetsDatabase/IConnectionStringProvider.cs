using System;
using System.Collections.Generic;
using System.Text;

namespace PetsDatabase
{
    public interface IConnectionStringProvider
    {
        string GetConnectionString();
    }
}
