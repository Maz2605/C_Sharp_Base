namespace Bai_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soTien;
            int giaVo;
            soTien = int.Parse(Console.ReadLine());
            giaVo = int.Parse(Console.ReadLine());
            int soVoMuaDuoc = soTien / giaVo;
            Console.WriteLine("SO VO MUA DUOC LA: {0}!!!!!", soVoMuaDuoc);
        }
    }
}
