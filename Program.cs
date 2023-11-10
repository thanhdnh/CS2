using System.Text;

class Program
{
    static void NhapTT1NV(object[] nv)
    {
        Console.WriteLine(" + Nhập họ tên nhân viên:");
        nv[0] = Console.ReadLine();
        Console.WriteLine(" + Nhập hệ số lương: ");
        nv[1] = float.Parse(Console.ReadLine());
        Console.WriteLine(" + Nhập phụ cấp theo ngày: ");
        nv[2] = int.Parse(Console.ReadLine());
    }
    static string XuatTT1NV(object[] nv)
    {
        long luong = (long)((float)nv[1]*1500000+(int)nv[2]*7);
        string result = "";
        result += "\t\t\tBẢNG LƯƠNG\n======\n";
        result += "Bảng lương cấp cho nhân viên:";
        result += $" + Họ tên: [{nv[0]}],\n";
        result += $" + Hệ số lương [{nv[1]}],\n";
        result += $" + Phụ cấp [{nv[2]}] VNĐ/ngày.";
        result += $"\nLương thực nhận: {luong} VNĐ";
        result += "\n\t\t\tT.P. Tài chính";
        result += "\n\t\t\t(Đã ký)";
        return result;
    }
    static void NhapTTCacNV(object[][] nvs){
        for(int i=0; i<nvs.Length; i++){
            Console.WriteLine($">> Nhập thông tin nhân viên {i}");
            NhapTT1NV(nvs[i]);
        }
    }
    static string XuatTTCacNV(object[][] nvs){
        string result = "";
        for(int i=0; i<nvs.Length; i++)
            result += XuatTT1NV(nvs[i]) + "\n\n";
        return result;
    }
    static object[][] KhoiTaoMangNV(int n){
        object[][] nvs = new object[n][];
        for(int i=0; i<nvs.Length; i++)
            nvs[i] = new object[3];
        return nvs;
    }
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Console.Clear();

        object[][] nvs = KhoiTaoMangNV(3);
        NhapTTCacNV(nvs);
        Console.WriteLine(XuatTTCacNV(nvs));

        Console.ReadLine();
    }
}