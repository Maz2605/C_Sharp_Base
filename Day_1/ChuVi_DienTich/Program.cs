namespace ChuVi_DienTich
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Viết chương trình cho nhập vào 2 cạnh của hình chữ nhật xuất ra chu vi và diện tích hình chữ nhật đó 
            int x, y;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            int D, S;
            D = (x + y) * 2;
            S = x * y;
            Console.WriteLine(D + " " + S);
        }
    }
}
