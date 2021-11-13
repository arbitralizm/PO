using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSES_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("podaj ilosc elementow w tablicy");
            int n = int.Parse(Console.ReadLine());
            int[] tab = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("podaj element");
                int a = int.Parse(Console.ReadLine());
                tab[i] = a;
            }

            foreach (int j in tab)
            {
                System.Console.Write("{0} ", j);
            }

            int[] tab1 = new int[] { 1, -2, 3, -3, 5, 0, -99, 7, 9, -32 };
            int[] tab2 = new int[10];
            int n = 0;
            int dl = tab1.Length;

            for (int i = 0; i < dl; i++)
            {
                int x = tab1[i];
                if (x > 0)
                {
                    tab2[n] = x;
                    n++;
                }
            }

            foreach (int j in tab2)
            {
                System.Console.Write("{0} ", j);
            }


            Console.WriteLine("Podaj ilosc elementow w tablicy: ");
            int dl = int.Parse(Console.ReadLine());
            int[] tablica = new int[dl];
            int min = 0;
            int max = 0;
            double srednia = 0;
            int dodatnie = 0;


            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine("Wpisz wartosc do elementu tablicy oraz nacisnij 'enter'");
                tablica[i] = int.Parse(Console.ReadLine());

                if (min > tablica[i])
                {
                    min = tablica[i];
                }
                if (max < tablica[i])
                {
                    max = tablica[i];
                }
                if (tablica[i] > 0)
                {
                    dodatnie++;
                }
                srednia += tablica[i];
            }
            int a = Array.IndexOf(tablica, min);
            int b = Array.IndexOf(tablica, max);
            srednia = srednia / tablica.Length;
            Console.WriteLine("\nNajmniejszy element: {0} index to: {1} \n" +
                "Najwiekszy element: {2} index to: {3} \n" +
                "Ilosc dodatnich elementow: {4} \n" +
                "Srednia to: {5}", min, a, max, b, dodatnie, srednia);


            int[] tab1 = { 0, 14, -2, 86, -76, 100 };
            int dl = tab1.Length;
            int[] tab2 = new int[dl];

            Array.Copy(tab1, 0, tab2, 1, 5);
            Array.Copy(tab1, 5, tab2, 0, 1);

            Console.Write("tab1: ");
            foreach (int i in tab1)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            Console.Write("tab2: ");
            foreach (int j in tab2)
                Console.Write("{0} ", j);
        }
    }
}
