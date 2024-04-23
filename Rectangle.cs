using ConsoleApp25;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp25;

internal class Rectangle : Shape
{
    public void Uxankyun()
    {
        //Koxm();
        Koxm4();
        string koxm4;
        double d;
        double p;
        double s;
        Console.WriteLine("Grel 4 koxm");
        void Koxm4()
        {
            Console.WriteLine("Grel 4 koxmy");
            do
            {
                koxm4 = Console.ReadLine();
                if (double.TryParse(koxm4.ToString(), out d) && d > 0)
                {
                    Console.WriteLine($"d = {koxm4}");
                    break;
                }
                else
                {
                    Console.WriteLine("Sxal koxm");
                }

            }
            while (true);
        }
        do
        {
            if ((a == d) && (c == b))
            {

                p = a + b + c + d;
                Console.WriteLine($"P = {p}");
                s = a * b;
                Console.WriteLine($"S = {s}");
                break;
            }
            else
            {
                Console.WriteLine("Sxal koxmer en nermucvac");
                Koxm();
                Koxm4();

            }
        }
        while (true);
    }

}
