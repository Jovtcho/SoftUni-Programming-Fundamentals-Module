﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine().ToList();
            inputString.Reverse();
            Console.WriteLine(string.Join("", inputString));
        }
    }
}
