using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector a1 = new Vector(4.1, 7.8);
            Vector b1 = new Vector(1.5, 7.5);
           
            Console.WriteLine();
            Console.WriteLine("===");
            Console.WriteLine(a1[1]);
           // Vector a2 = new Vector(2.3, 1.1);
            double s = (double)a1;
            Console.WriteLine(s);
            Vector b = a1;
            Console.WriteLine(b);
            Console.WriteLine("_____");
            Console.WriteLine($"{-a1}");

           /* if (a1)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }*/
            //Console.WriteLine(a1==b1);
           // Vector a3 = a1 + a2;
            //Vector a4 = a1 - a2;
            //Console.WriteLine(a1);
            
            //Console.WriteLine(a2);
            //Console.WriteLine("__________");
            //a1++;
            //Console.WriteLine(a1);
            //a1--;
            //Console.WriteLine(a1);
           // Console.WriteLine(a1*a2);

            //Console.WriteLine($"A1 + A2 = {a3}");
            //Console.WriteLine($"A1 - A2 = {a4}");
            //double num = 5.5;
            //Vector a5 = a1*num;
            //Console.WriteLine("________");
            //Console.WriteLine(a5);
           
            //a1.lengthVector();
        }
    }
}
