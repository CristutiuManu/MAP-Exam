using System;
using System.IO;

namespace Problema7MAP
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("./../../../input.in", FileMode.Open);
            StreamReader st = new StreamReader(fs);

            int x = int.Parse(st.ReadLine().Trim());
            int y = int.Parse(st.ReadLine().Trim());
            int z;

            Console.Write($"{y} {x} ");

            while (x > 0)
            {
                z = 2 * x - y + 2;

                File.AppendAllText(@"./../../../output.out", z.ToString() + " ");

                y = x;
                x = z;
            }
        }
    }
}

