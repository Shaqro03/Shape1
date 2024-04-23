using ConsoleApp25;

namespace ConsoleApp25;

internal class Triangle : Shape
{
    public void Erankyun()
    {
        //Koxm();
        double p;
        double s;
        do
        {
            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                p = a + b + c;
                Console.WriteLine($"p = {p}");

                s = Math.Sqrt((((a + b + c) / 2) * (((a + b + c) / 2) - a) * (((a + b + c) / 2) - b) * (((a + b + c) / 2) - c)));

                Console.WriteLine($"S =  {s}");
                break;
            }
            else
            {
                Console.WriteLine("Sxal koxmer en nermucavc");
                Koxm();

            }
        }
        while (true);

    }
}
