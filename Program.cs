using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSES_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 3.1.

             int rok_przestepny;
             Console.WriteLine("Wpisz rok, aby sprawdzic czy jest on przestepny ");
             rok_przestepny = int.Parse(Console.ReadLine());

             if (rok_przestepny % 4 == 0 && rok_przestepny % 100 != 0 || rok_przestepny % 400 == 0 )
                 Console.WriteLine("True");
             else
                 Console.WriteLine("False");
             Console.ReadKey(); 

            //Zadanie 3.2.

            Console.WriteLine("Podaj 2 liczby, aby sprawdzic czy druga liczba jest dzielnikiem pierwszej");
            Console.WriteLine("Liczba 1: ");
            int liczba1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Liczba 2: ");
            int liczba2 = int.Parse(Console.ReadLine());
            
            if (liczba1 % liczba2 == 0)
                    Console.WriteLine("True");
                    
            else
                    Console.WriteLine("False");
            Console.ReadKey(); 

            //Zadanie 3.3.

            Console.WriteLine("Podaj 3 liczby, aby sprawdzic, ktora z nich jest wieksza");
            Console.WriteLine("Liczba 1: ");
            int liczba1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Liczba 2: ");
            int liczba2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Liczba 3: ");
            int liczba3 = int.Parse(Console.ReadLine());

            if (liczba1 > liczba2 && liczba1 > liczba3)
                Console.WriteLine(liczba1);
            else if (liczba2 > liczba1 && liczba2 > liczba3)
                Console.WriteLine(liczba2);
            else if (liczba3 > liczba1 && liczba3 > liczba2)
                Console.WriteLine(liczba3);
            Console.ReadKey(); 

            //Zadanie 3.4.

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

            //Zadanie 3.5.

            Console.WriteLine("Oblicz pierwiastki rownania kwadratowego ax^2 + bx + c = 0, gdzie a != 0");
            Console.WriteLine("Podaj a: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj b: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj c: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("Obliczamy delte: ");
            double delta = (b * b) - (4.0 * a * c);
            Console.WriteLine(delta);

            double sqrt = Math.Sqrt(delta);
            Console.WriteLine("Pierwiastek z delty = ");
            Console.WriteLine(sqrt);
            double x0 = (-b) / (2.0 * a);
            double x1 = ((-b) + sqrt) / 2.0 * a;
            double x2 = ((-b) - sqrt) / 2.0 * a;
            if (delta < 0)
                Console.WriteLine("Brak rozwiazania, poniewaz delta < 0 ");
            else if (delta == 0)
            {
                Console.WriteLine("x0 = ");
                Console.WriteLine(x0);
            }
            else if (delta > 0)
            {
                Console.WriteLine("Pierwiastki x1 oraz x2 = ");
                Console.WriteLine(x1);
                Console.WriteLine(x2);
            }
            Console.ReadKey(); 

            // Zadanie 3.6.

            Console.WriteLine("Podaj wage w kg: ");
            double kg = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wzrost w metrach np.: 1,75 : ");
            double m = double.Parse(Console.ReadLine());
            double m2 = m * m;
            double BMI = kg / m2;
            Console.WriteLine("Twoje BMI = ");
            Console.WriteLine(BMI);
            //a
            if (BMI < 18.5)
                 Console.WriteLine("NIEDOWAGA");
             else if (BMI == 18.5 || 18.5 <= 24.99)
                 Console.WriteLine("WARTOSC PRAWIDLOWA");
             else if (BMI >= 25.0)
                 Console.WriteLine("NADWAGA"); 

            //b
            if (BMI < 16.0)
                Console.WriteLine("WYGLODZENIE");
            else if (BMI == 16.0 || 16.0 <= 16.99)
                Console.WriteLine("WYCHUDZENIE");
            else if (BMI == 17.0 || 17.0 <= 18.49)
                Console.WriteLine("NIEDOWAGA");
            else if (BMI == 18.5 || 18.5 <= 24.99)
                Console.WriteLine("WARTOSC PRAWIDLOWA");
            else if (BMI == 25.0 || 25.0 <= 29.99)
                Console.WriteLine("NADWAGA");
            else if (BMI == 30.0 || 30.0 <= 34.99)
                Console.WriteLine("OTYLOSC I STOPNIA");
            else if (BMI == 35.0 || 35.0 <= 39.99)
                Console.WriteLine("OTYLOSC II STOPNIA");
            else if (BMI >= 40.0)
                Console.WriteLine("OTYLOSC III STOPNIA");

            Console.ReadKey(); 

            //Zadanie 3.7.
            Console.WriteLine("Wpisz nr dnia tygodnia"); 
            string numer = Console.ReadLine();

            switch (numer)
            {
                case "1":
                    Console.WriteLine("Monday");
                    break;
                case "2":
                    Console.WriteLine("Tuesday");
                    break;
                case "3":
                    Console.WriteLine("Wednesday");
                    break;
                case "4":
                    Console.WriteLine("Thursday");
                    break;
                case "5":
                    Console.WriteLine("Friday");
                    break;
                case "6":
                    Console.WriteLine("Saturday");
                    break;
                case "7":
                    Console.WriteLine("Sunday");
                    break;
            }
            Console.ReadKey(); 

            //Zadanie 3.8.

            Console.WriteLine("Podaj wartosc sredniej ocen, aby wyswietlic informacje o wysokosci przyslugujacego stypendium: ");
            double srednia = double.Parse(Console.ReadLine());

            if (srednia == 2.00 || 2.00 <= 3.99)
                Console.WriteLine("Stpendium w kwocie 0,00 zlotych");
            else if
                (srednia == 4.00 && 4.00 <= 4.79)
                Console.WriteLine("Stypendium w kwocie 350,00 zlotych");  
            else if
                (srednia == 4.80 || 4.80 <= 5.00)
                Console.WriteLine("Stypendium w kwocie 550,00 zlotych");

            Console.ReadKey(); 

            //zadanie 3.9.

            Console.WriteLine("Wpisz a; b; c; lub d; aby wybrac swoj wariant: ");
            string znak = (Console.ReadLine());

            switch (znak)
            {
                case "a":
                    Console.WriteLine("*\n" +  "**\n" +"***\n" +"****\n");
                    break;
                case "b":
                    Console.WriteLine("****\n" + "***\n" + "**\n" + "*\n");
                    break;
                case "c":
                    Console.WriteLine("      *\n" + "     **\n" + "    ***\n" + "   ****\n");
                    break;
                case "d":
                    Console.WriteLine("****\n" + "" + "*  *\n" + "*  *\n" + "****\n");
                    break;
            }
            Console.ReadKey(); 

            //zadanie 3.10.

            Console.WriteLine("Wpisz liczbe, aby obliczyc n! ");
            int n = int.Parse(Console.ReadLine());
            int silnia = 1;
            for(int i = silnia; i <= n; i++)
            {
                silnia *= i;
            }
            Console.WriteLine(silnia);
            Console.ReadKey(); 

            //zadanie 3.11

            int ile_liczb = 0, suma = 0, liczba = 1;
            while (suma < 100)
            {
                ile_liczb++;
                suma += ile_liczb;
                liczba++;
            }
            Console.Write("Ilość użytych liczb: {0} | Największa użyta liczba: {1} | Suma: {2}", ile_liczb, liczba, suma);
            Console.ReadKey(); 

            //zadanie 3.12

            Console.WriteLine("Podaj liczbe calkowita: ");
            int calkowita = int.Parse(Console.ReadLine());
            int result = 0;
            result += calkowita;
            while (calkowita != 0)
            {
                Console.WriteLine("Podaj jeszcze raz");

                result += int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Suma jest rowna ", result);
            Console.ReadKey();

        }   
    }
}
