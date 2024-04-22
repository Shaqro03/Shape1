namespace ConsoleApp25;

internal class Shape
{
    public double a;
    public double b;
    public double c;
    public string koxm1;
    public string koxm2;
    public string koxm3;
    public void Koxm()
    {
        Console.WriteLine("Grel 1 koxmy");

        do
        {
            koxm1 = Console.ReadLine();
            if (double.TryParse(koxm1.ToString(), out a) && a > 0)
            {
                Console.WriteLine($"a = {koxm1}");
                break;
            }
            else
            {
                Console.WriteLine("sxal koxm e");

            }
        }
        while (true);

        Console.WriteLine("Grel 2 koxmy");

        do
        {
            koxm2 = Console.ReadLine();
            if (double.TryParse(koxm2.ToString(), out b) && b > 0)
            {
                Console.WriteLine($"b = {koxm2}");
                break;
            }
            else
            {
                Console.WriteLine("sxal koxm e");

            }
        }
        while (true);

        Console.WriteLine("Grel 3 koxmy");

        do
        {
            koxm3 = Console.ReadLine();
            if (double.TryParse(koxm3.ToString(), out c) && c > 0)
            {
                Console.WriteLine($" c = {koxm3}");
                break;
            }
            else
            {
                Console.WriteLine("sxal koxm e");

            }
        }
        while (true);

    }


}
