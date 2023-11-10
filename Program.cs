using System.Text;

class Program
{
    static void NhapTT1NV(object[] nv)
    {
        Console.WriteLine("Nhập họ tên nhân viên:");
        nv[0] = Console.ReadLine();
        Console.WriteLine("Nhập hệ số lương: ");
        nv[1] = float.Parse(Console.ReadLine());
        Console.WriteLine("Nhập phụ cấp theo ngày: ");
        nv[2] = int.Parse(Console.ReadLine());
    }
    static string XuatTT1NV(object[] nv)
    {
        return $"Nhân viên: {nv[0]}, Hệ số lương: {nv[1]}, Phụ cấp ngày: {nv[2]}";
    }
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Console.Clear();

        object[] nv = new object[3];
        NhapTT1NV(nv);
        XuatTT1NV(nv);

        Console.ReadLine();
    }
}