using System;
using System.Collections.Generic;

namespace ConsoleApp8
{
    public class NameProcessor
    {
        private readonly List<string> names = new List<string>();

        public void Add(string name)
        {
            var newName = name.Substring(0, 1).ToUpper() + name.Substring(1);
            names.Add(newName);
        }

        public List<string> GetNamesStartingWith(string start)
        {
            var newList = new List<string>();
            foreach (var name in names)
            {
                if (name.StartsWith(start))
                {
                    newList.Add(name);
                }
            }
            return newList;
        }
    }
}