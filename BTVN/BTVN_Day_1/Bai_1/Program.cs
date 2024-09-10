namespace Bai_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, t;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());
            t = int.Parse(Console.ReadLine());
            Console.WriteLine($"{x}  {y}  {z}  {t}\n");
            Console.WriteLine($"{x} -- {y} -- {z} -- {t}\n");
            Console.WriteLine($"{2*x}, {3*y}, {4*z}, {5*t}\n");
            Console.WriteLine("KET THUC!!!!!");
        }
    }
}
