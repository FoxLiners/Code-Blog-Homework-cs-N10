using System;

namespace PROEKT__NAFIG_
{
    class Program
    {


        static void Main(string[] args)
        {
            var prodavez1 = new Prodavez("Евгений","Евгенев");
            var Human1 = new Human("Иванов", "Иван");
            var Human2 = new Human("Петров", "Петр");
            var Human3 = new Human("Сергеев", "Сергей");
            var Human4 = new Human("Владимиров", "Владимиров");
            var Human5 = new Human("Романов", "Роман");
            var Human6 = new Human("Александрович", "Александр");
            var Human7 = new Human("Кристинова", "Кристина");
            var Human8 = new Human("Мариева", "Мария");

            for (; ;)
            {
                System.Threading.Thread.Sleep(6000);
                Console.WriteLine("Покупатель информация :");
                var mark1 = Human1.Marks();
                var prod1 = prodavez1.Skliad();
                Console.WriteLine(mark1);
                Console.WriteLine("Продавец информация :");
                Console.WriteLine(prod1);

                System.Threading.Thread.Sleep(6000);
                Console.WriteLine("Покупатель :");
                var mark2 = Human2.Marks();
                var prod2 = prodavez1.Skliad();
                Console.WriteLine(mark2);
                Console.WriteLine("Продавец информация :");
                Console.WriteLine(prod2);

                System.Threading.Thread.Sleep(6000);
                Console.WriteLine("Покупатель :");
                var mark3 = Human3.Marks();
                var prod3 = prodavez1.Skliad();
                Console.WriteLine(mark3);
                Console.WriteLine("Продавец информация :");
                Console.WriteLine(prod3);

                System.Threading.Thread.Sleep(6000);
                Console.WriteLine("Покупатель :");
                var mark4 = Human4.Marks();
                Console.WriteLine(mark1);
                Console.WriteLine("Продавец информация :");
                Console.WriteLine(prod1);

                System.Threading.Thread.Sleep(6000);
                Console.WriteLine("Покупатель :");
                var mark5 = Human5.Marks();
                Console.WriteLine(mark2);
                Console.WriteLine("Продавец информация :");
                Console.WriteLine(prod3);

                System.Threading.Thread.Sleep(6000);
                Console.WriteLine("Покупатель :");
                var mark6 = Human6.Marks();
                Console.WriteLine(mark6);
                Console.WriteLine("Продавец информация :");
                Console.WriteLine(prod2);

                System.Threading.Thread.Sleep(6000);
                Console.WriteLine("Покупатель :");
                var mark7 = Human7.Marks();
                Console.WriteLine(mark7);
                Console.WriteLine("Продавец информация :");
                Console.WriteLine(prod1);

                System.Threading.Thread.Sleep(6000);
                Console.WriteLine("Покупатель :");
                var mark8 = Human8.Marks();
                Console.WriteLine(mark8);
                Console.WriteLine("Продавец информация :");
                Console.WriteLine(prod3);
            }
        }
    }
}
