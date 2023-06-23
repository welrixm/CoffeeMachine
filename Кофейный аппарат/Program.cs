using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace coffee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cofevubor cof = new cofevubor();
            cof.menu();
            Console.WriteLine(" ");
            cof.number = Console.ReadLine();

            cof.qqq(cof.number);


            Console.WriteLine("введите сумму ");
            while (true)
            {
                try
                {
                    cof.sum = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("не известно");
                }
            }
            cof.pocub(cof.sum);
            cof.toint();
            Console.ReadKey();
        }
    }
}
