using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputLine = Console.ReadLine().Split().ToList();

            string num = null;
            double num1 = null;

            var nums = inputLine.Where((str, index) => index % 2 == 0).Select(str => str).Select(str => int.Parse(str)).ToList();
            var material = inputLine.Where((str, index) => index % 2 == 1).Select(str => str).ToList();


            //List<string> removedElement = inputLine.RemoveRange(inputLine.Count - 2, 2);

            Console.WriteLine();

        }
    }
}
