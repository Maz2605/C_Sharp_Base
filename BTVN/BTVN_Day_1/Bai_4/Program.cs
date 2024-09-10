namespace Bai_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine(a + " " + b);
            int temp = b;
            b = a;
            a = temp;
            Console.WriteLine(a + " " + b);
        }
    }
}
