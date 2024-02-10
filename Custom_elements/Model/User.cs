using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_elements.Model
{
    public class User
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }
        public string Emale { get; set; }
        public User(string name, string country, int age, string emale)
        {
            Name = name;
            Country = country;
            Age = age;
            Emale = emale;

        }
    }
}
