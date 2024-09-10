namespace Bai_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                int temp = b;
                b = a;
                a = temp;
            }
            int c = b - a + 1;
            Console.WriteLine(c);
        }
    }
}
