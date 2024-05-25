using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindByNameReflection
{
    internal class House
    {
        public int Age;
        public int Size;
        public string Street;
        public House(int age, int size, string street)
        {
            Age = age;
            Size = size;
            Street = street;
        }
        public override string ToString()
        {
            return $"\nAge:\t{Age}\nSize:\t{Size}\nStreet:\t{Street}";
        }
    }
}
