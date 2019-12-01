using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2019Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            var results = new List<int>();
            using (StreamReader reader = File.OpenText("input.txt"))
            {
                while (!reader.EndOfStream)
                {
                    int x = int.Parse(reader.ReadLine());
                    //Console.WriteLine(x);
                    numbers.Add(x);
                }
            }

            for (var i = 0; i < numbers.Count; i++)
            {
                
                int result = 0;
                numbers[i] = numbers[i] / 3 - 2;
                while (numbers[i] > 0)
                {
                    result += numbers[i];
                    numbers[i] = numbers[i] / 3 - 2;
                    //Console.WriteLine(temp);
                }
                results.Add(result);
                Console.WriteLine(result);
            }





            int total = results.Sum(x => Convert.ToInt32(x));
            Console.WriteLine(total);
        }
    }
}
