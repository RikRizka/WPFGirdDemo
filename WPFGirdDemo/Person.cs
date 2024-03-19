using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFGirdDemo
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Geslacht { get; set; }
        public string Land { get; set; }

        public Person(string name, int age, string geslact, string land)
        {
            Name = name;
            Age = age;
            Geslacht = geslact;
            Land = land;
        }

    }
}
