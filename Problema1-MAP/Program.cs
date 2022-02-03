using System;

namespace Problema1_MAP
{
    public class Program
    {
        static void Main(string[] args)
        {

            /*
                1. Scrieţi un program C# care citeşte de la tastatură două numere naturale din 
                intervalul [3,50], n şi m, și elementele unui tablou bidimensional cu n linii şi m 
                coloane, numere naturale din intervalul [0,104]. Programul modifică în memorie 
                tabloul dat, atribuind valoarea elementului aflat pe ultima linie și pe ultima coloană
                a tabloului fiecărui element aflat pe conturul acestuia (pe prima linie, ultima linie, 
                prima coloană, ultima coloană), apoi afişează pe ecran tabloul modificat, câte o linie 
                a tabloului pe câte o linie a ecranului, elementele fiecărei linii fiind separate prin 
                câte un spaţiu.
            */


            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[,] a = new int[51, 51];

            //int[,] a = { { 0, 5, 2, 11 }, { 3, 2, 10, 2 }, { 7, 3, 1, 4 }, { 4, 5, 0, 12 }, { 8, 13, 7, 5 } };


            for (int i = 1; i <= n; ++i)
                for (int j = 1; j <= m; ++j)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }

            int val = a[n - 1, m - 1];

            for (int i = 0; i < n; i++)
            {
                a[i, 0] = val;
                a[i, m - 1] = val;
            }
            for (int i = 0; i < m; i++)
            {
                a[0, i] = val;
                a[n - 1, i] = val;
            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write($"{a[i, j]} ");
                Console.WriteLine();
            }
        }
    }
}

