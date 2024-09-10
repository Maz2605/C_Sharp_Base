namespace Bai_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());
            e = double.Parse(Console.ReadLine());
            double avg = (a + b + c + d + e) / 5;
            Console.WriteLine("{0:F2}",avg);
        }
    }
}
