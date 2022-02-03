using System;
using System.IO;
using System.Threading.Tasks;

namespace Problema10MAP
{
    class Program
    {
        static async Task Main(string[] args)
        {
            FileStream fs = new FileStream("./../../../input.in", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            int n = int.Parse(sr.ReadLine().Trim());
            int m = int.Parse(sr.ReadLine().Trim());

            int min = n * 2 >= n ? 0 : n - 2 * m;

            int k = 0;
            while (k * (k - 1) / 2 < m) k++;
            int max = n - k;

            await File.AppendAllTextAsync(@"./../../../output.out", min.ToString() + " " +  max.ToString());
        }
    }
}

