using System;             // using to dyrektywa
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSESS_1    //namespace to przestrzeń nazw
{
    class Program
    {
        static void Main(string[] args)
        {

            
            // Zadanie 2.1.
            Console.WriteLine("Podaj temperatrue w stopniach C: ");
            double C, F;
            C = double.Parse(Console.ReadLine());
            F = 32d +( 9.0 / 5.0) * C;
            Console.WriteLine(F);
            Console.ReadKey();

            //Zadanie 2.2.
            Console.WriteLine("Podaj a: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj c: ");
            int c = int.Parse(Console.ReadLine());

            int delta = b * b - 4 * a * c;
            Console.WriteLine(delta);
            Console.ReadKey(); 

            //Zadanie 2.3.
            Console.WriteLine("Podaj wage w kg: ");
            double kg = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wzrost w metrach np.: 1,75 : ");
            double m = double.Parse(Console.ReadLine());
            double BMI = kg / m;
            Console.WriteLine(BMI);
            Console.ReadKey(); 

            //Zadanie 2.4.
            int x = 100;
            Console.WriteLine(++x*2);
            Console.ReadKey();
            // odpowiedź: 202 

            //Zadanie 2.5.
            int x = 2, y = 3;
            x *= y * 2;
            Console.WriteLine(x);
            Console.ReadKey(); 

            //Zadanie 2.6.
            int x, y = 4;
            x = (y-=2);
            x = y++;
            x = y--;
            Console.WriteLine(x);
            Console.ReadKey();
            // odpowiedź: 3 

            //Zadanie 2.7.
            int x, y = 5;
            x = ++y * 2;
            x = y++;
            x = y--;
            Console.WriteLine(++y);
            Console.ReadKey();
            // odpowiedź: 7 

            // Zadanie 2.8.
            bool x;
            int y = 1, z = 1;
            x = (y == 1 && z++ == 1);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.ReadKey();
            // odpowiedź: true, 1, 2 

            //Zadanie 2.9.

            int x = 1, y = 4, z = 2;

            bool wynik = (x++ > 1 && y++ == 4 && z-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            Console.WriteLine("--------------------------------------");
            Console.ReadKey();

            int x1 = 1, y1 = 4, z1 = 2;
            bool wynik1 = (x1++ > 1 & y1++ == 4 && z1-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x1, y1, z1);
            Console.WriteLine("--------------------------------------");
            Console.ReadKey(); 
            
            int x2 = 1, y2 = 4, z2 = 2;
            bool wynik2 = (x2++ > 1 & y2++ == 4 & z2-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik2, x2, y2, z2);
            Console.WriteLine("--------------------------------------");
            Console.ReadKey();

            int x3 = 1, y3 = 4, z3 = 2;
            bool wynik3 = (x3++ > 1 || y3++ == 4 || z3-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik3, x3, y3, z3);
            Console.WriteLine("--------------------------------------");
            Console.ReadKey();

            int x4 = 1, y4 = 4, z4 = 2;
            bool wynik4 = (x4++ > 1 | y4++ == 4 || z4-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik4, x4, y4, z4);
            Console.WriteLine("--------------------------------------");
            Console.ReadKey();

            int x5 = 1, y5 = 4, z5 = 2;
            bool wynik5 = (x5++ > 1 | y5++ == 4 | z5-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik5, x5, y5, z5);
            Console.WriteLine("--------------------------------------");
            Console.ReadKey();
            // odpowiedź: pierwsze 3 = False, kolejne 3 = True

            //Zadanie 2.10.

            int powierzchnia = 100, osoby = 10;
            double gestosc_zaludnienia = (double)osoby / powierzchnia;
            Console.WriteLine(gestosc_zaludnienia);
            Console.ReadKey();

            // odpowiedź: 0,1

        }
    }
}

/* referncja zawiera adres (odniesienie) do miejsca, gdzie coś jest przechowywane 
referncje zapisuje się na STOSIE, a dane, na które referencja wskazuje - zapisuje się na STERCIE
typy referencyjne to TABLICE, ŁAŃCUCHY ZNAKOWE i KLASY */