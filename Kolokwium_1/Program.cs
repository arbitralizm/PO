using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1

            Console.WriteLine("Podaj dwie liczby oraz jeden ze znakow '+, -, /, *', aby wykonac dzialanie : ");
            Console.WriteLine("Podaj liczbe: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbe: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj znak: ");
            string znak = Console.ReadLine();
            double wynik = 0;
          
            switch (znak)
            {
                case "+":
                    wynik = a + b;
                    break;
                case "-":
                    wynik = a - b;
                    break;
                case "*":
                    wynik = a * b;
                    break;
                case "/":
                    wynik = a / b;
                    break;


            }
            Console.WriteLine(wynik);
            Console.ReadKey();

            //Zadanie 2

            Console.WriteLine("Wpisz liczbe n: ");
            int n = int.Parse(Console.ReadLine());

            while(n > 10)
            {
                Console.WriteLine("Podaj liczbe ponownie, jest za duza");
                n = int.Parse(Console.ReadLine());
            }
            if (n <= 10)
                Console.WriteLine("Podana liczba jest mniejsza lub równa 10");

            Console.WriteLine();
            Console.ReadKey();
            //-------------------------------------------------
            int[] tab = new int[4];
            Console.WriteLine("Podaj liczbe: ");
            tab[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbe: ");
            tab[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbe: ");
            tab[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbe: ");
            tab[3] = int.Parse(Console.ReadLine());
            int suma = 0;
            for(int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("{0}, ", tab[i]);
                suma += tab[i];
            }
            Console.WriteLine("Suma podanych liczb: {0}", suma);


            Console.WriteLine(tab);
            Console.ReadKey();

            //Zadanie 3 
            Console.WriteLine("Podaj liczbe n ");
            float x = float.Parse(Console.ReadLine());
            float dodatnie = 0, ujemne = 0;
            while (x != 0)
            {
                Console.WriteLine("Podaj liczbe: ");
                x = float.Parse(Console.ReadLine());
                if (x > 0)
                {
                    dodatnie++;
                }
                    
                else if (x < 0)
                {
                    ujemne++;
                }

                
            }
            Console.WriteLine("Dodatnie: {0}", dodatnie);
            Console.WriteLine("Ujemne: {0}", ujemne);
            Console.ReadKey();
        }
    }
}
