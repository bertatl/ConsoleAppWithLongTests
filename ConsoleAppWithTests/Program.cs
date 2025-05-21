using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathUtils;

namespace ConsoleAppWithTests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ma = new MathOperations();
            Console.WriteLine(ma.Add(1, 2));
        }
    }
}
