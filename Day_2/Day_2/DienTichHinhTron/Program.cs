namespace DienTichHinhTron
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tính chu vi diện tích hình tròn nhập r => Chu vi và diện tich 
            //Chu vi của hình tròn: r * 2 * pi
            //Dien tich hình tròn:  r * r * pi
            double r = Convert.ToDouble(Console.ReadLine());
            double S = r * r * Math.PI;
            double C = 2 * r * Math.PI;
            Console.WriteLine("Chu vi C = " + C);
            Console.WriteLine("Dien tich S = " + S);


        }
    }
}
