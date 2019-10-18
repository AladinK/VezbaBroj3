using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VezbanjeBroj3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nizCelihBrojeva = { 1, 6, 7, 20, 409 };
            Console.WriteLine(nizCelihBrojeva[0]);
            Console.WriteLine("Unesite velicinu:");
            int elemenata = int.Parse(Console.ReadLine());
            int[] drugiNiz = new int[elemenata];
            for (int i = 1; i <= elemenata; i++)
            {
                drugiNiz[i - 1] = i * 2;
            }
            Console.WriteLine($"Niz je dugacak {drugiNiz.Length}");
            foreach(int broj in drugiNiz)
            {
                Console.WriteLine(broj);
            }
            Console.ReadKey();
        }
    }
}
