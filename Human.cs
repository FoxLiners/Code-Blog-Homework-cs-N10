using System;
using System.Collections.Generic;
using System.Text;

namespace PROEKT__NAFIG_
{
    class Human
    {
        public string Name { get; set; }

        public string SecondName { get; set; }

        public int age { get; set; }

        public int X { get; set; }

        public string rndpoc { get; set; }

        public Human(string secondname, string name)
        {
            SecondName = secondname;

            Name = name;

            X = 0;
        }

        public string Marks()
        {
            var rnd = new Random();

            X += rnd.Next(1, 100);

            age = rnd.Next(8,99);

            return $"Name - {Name}\n" + 
                $"Secondname - {SecondName} \n" + 
                $"Mark - {age}\n";
        }
    }
}
