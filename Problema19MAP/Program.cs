using System;
using System.IO;

namespace Problema19MAP
{
    class Program
    {
        public static int[] array;
        public static int n;
        public static int k;

        static void Main(string[] args)
        {
            FileStream fs = new FileStream("./../../../input.in", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            n = int.Parse(sr.ReadLine().Trim());
            k = int.Parse(sr.ReadLine().Trim());
            array = new int[k];

            sr.Close();
            fs.Close();

            BackTracking(0);
        }

        public static bool Verify(int position)
        {
            for (int i = 0; i < position; i++)
                if (array[i] >= array[position])
                    return false;
            return true;
        }

        public static void BackTracking(int position)
        {
            for (int i = 1; i < n; i++)
            {
                array[position] = i;
                if (Verify(position))
                {
                    if (position == k - 1)
                    {
                        for (int j = 0; j < k; j++)
                        {
                            var value = array[j];
                            File.AppendAllText(@"./../../../input.out", value.ToString());
                        }
                        File.AppendAllText(@"./../../../input.out", "\n");
                    }
                    else
                        BackTracking(position + 1);
                }
            }
        }
    }
}

