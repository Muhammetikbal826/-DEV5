using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1; int b = 2; int c = 3; int d = 4; int e = 5; int f = 6; int g = 7; int h = 8; int i = 24; int j = 48;
            double sonuc1 = j / f / d;
            Console.WriteLine("1.örneğin sonucu : " + sonuc1);
            Console.ReadLine();
            double sonuc2 = i / c * b;
            Console.WriteLine("2.örneğin sonucu : " + sonuc2);
            Console.ReadLine();
            double sonuc3 = Math.Pow(b, b) + e - a + d;
            Console.WriteLine("3.örneğin sonucu : " + sonuc3);
            Console.ReadLine();
            double sonuc4 = (g + d) * b - a + h / b;
            Console.WriteLine("4.örneğin sonucu : " + sonuc4);
            Console.ReadLine();
            double sonuc5 = (e - a) * b - a + Math.Pow(g, g) / b;
            Console.WriteLine("5.örneğin sonucu : " + sonuc5);
            Console.ReadLine();











        }
    }
}