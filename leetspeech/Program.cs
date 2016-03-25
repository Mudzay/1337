using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetspeech
{
    class Program
    {
        static string gufno;
        static void leet(string arg)
        {
            foreach (char c in arg)
            {               
                if (c.ToString() == "a")
                {
                    Console.Write("4");
                } else if (c.ToString() == "e")
                {
                    Console.Write("3");
                } else if (c.ToString() == "l")
                {
                    Console.Write("1");
                } else if (c.ToString() == "o")
                {
                    Console.Write("0");
                } else if (c.ToString() == "s")
                {
                    Console.Write("5");
                } else if (c.ToString() == "t")
                {
                    Console.Write("7");
                } else if (c.ToString() == "z")
                {
                    Console.Write("2");
                } else
                {
                    Console.Write(c);
                }
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Insert text: ");
                gufno = Console.ReadLine();
                leet(gufno);
                Console.ReadKey();
            }
        }
    }
}
