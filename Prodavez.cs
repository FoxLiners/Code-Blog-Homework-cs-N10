using System;
using System.Collections.Generic;
using System.Text;

namespace PROEKT__NAFIG_
{
    class Prodavez
    {
        public string Name { get; set; }

        public string SecondName { get; set; }

        public int Ballance { get; set; }

        public int Ballance2 { get; set; }

        public int Sklad { get; set; }

        public int TupoRandom { get; set; }

        public Prodavez(string name,string secondname)
        {
            Name = name;

            SecondName = secondname;

        }

        public string Skliad()
        {
            var rnd = new Random();

            Sklad = rnd.Next(0,4999);

            Ballance = 0;

            TupoRandom = rnd.Next(1,15000);

            Ballance2 = Ballance + TupoRandom;

            return $"Имя - {Name}\n" +
                $"Фамилия - {SecondName}\n" +
                $"На складе - {Sklad} товаров\n" +
                $"В кассе {Ballance2} USD\n";
        }
    }
}
