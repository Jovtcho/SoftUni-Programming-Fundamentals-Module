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
            var inputLine = Console.ReadLine().ToLower().Split().ToList();

            //var nums = new List<int>();

            var nums = inputLine.Where((str, index) => index % 2 == 0).Select(str => str).Select(str => int.Parse(str)).ToList();
            var material = inputLine.Where((str, index) => index % 2 == 1).Select(str => str).ToList();


            //   foreach (var str in inputLine)
            //   {
            //       int num;
            //       var isNum = int.TryParse(str, out num);
            //       nums.Add(num);
            //   }

            //    var inputNum = Console.ReadLine();
            //    var num = 0;
            //    var isNum = int.TryParse(inputNum, out num);

            Console.WriteLine();

        }
    }
}
