using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab6
{
    class Program
    {
        class example
        {
            public int x;
            public int y;
            public example(int x)
            {
                this.x = x;
            }
            static public void Init(example a)
            {
                a.x = a.y = 1;
            }
            static public void Sqr(ref double a, ref double b)
            {
                a = Math.Pow(a, 2);
                b = Math.Pow(b, 2);
                WriteLine($"a = {a} \t b = {b}");
            }
            static public void info(double a)
            {
                char c = a > 0 ? '+' : '-';

            }
        }
        static public double avarge(params double[] arr)
        {
            double sum = 0;
            foreach (double item in arr)
            {
                sum += item;
            }
            return sum / arr.Length;
        } 

        static void Main(string[] args)
        {
            double a = 12.12, b = 22.22;
            WriteLine($"{a} - {b}");
            example.Sqr(ref a, ref b);
            WriteLine($"{a} - {b}");
            example obj = new example(2);
            WriteLine($"� ������ Main: obj.x = {obj.x}\tobj.y = {obj.y}");
            example.Init(obj);
            WriteLine($"� ������ Main: obj.x = {obj.x}\tobj.y = {obj.y}");

            WriteLine($"{avarge(12, 15, 16.6)} => () = {avarge()}");
            ReadKey();
        }
    }
}
