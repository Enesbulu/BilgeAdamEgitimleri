using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            i *= i++ + --i * (i++ - ++i);
Console.Write(i);
            Console.ReadKey();
        }
    }
}
