using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_Simon_Says;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Simon simon = new Simon();
            Console.WriteLine(simon.Echo("Hello Mum - send more money"));
            Console.WriteLine(simon.Repeat("hi"));
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("The value of I is : " + i);
            }
            Console.WriteLine(simon.Shout("hello - is it me you are looking for?"));
            Console.WriteLine("Press any key please :)");
            Console.ReadKey();
        }
    }
}
