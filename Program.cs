using System.Text;
using System;

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
    static long TinhLuong(object[] nv){
        return (long)((float)nv[1]*1500000+(int)nv[2]*7);
    }
    static string XuatTT1NV(object[] nv)
    {
        string result = "";
        result += "\t\tBẢNG LƯƠNG\n\t\t======\n";
        result += "Bảng lương cấp cho nhân viên:\n";
        result += $" + Họ tên: [{nv[0]}],\n";
        result += $" + Hệ số lương [{nv[1]}],\n";
        result += $" + Phụ cấp [{nv[2]}] VNĐ/ngày.";
        result += $"\nLương thực nhận: {TinhLuong(nv)} VNĐ";
        result += "\n\t\tT.P. Tài chính";
        result += "\n\t\t(Đã ký)";
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
    static int DemNVTheoLuong(object[][] nvs, long f, long t){
        int count = 0;
        for(int i=0; i<nvs.Length; i++)
            if(TinhLuong(nvs[i])>=f && TinhLuong(nvs[i])<=t)
                count++;
        return count;
    }
    static object[][] LocNVTheoLuong(object[][] nvs, long f, long t){
        int count = DemNVTheoLuong(nvs, f, t);
        object[][] result = KhoiTaoMangNV(count);
        int index = 0;
        for(int i=0; i<nvs.Length; i++)
            if(TinhLuong(nvs[i])>=f && TinhLuong(nvs[i])<=t){
                    result[index++] = nvs[i];
                }
        return result;
    }
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Console.Clear();

        object[][] nvs = KhoiTaoMangNV(3);
        NhapTTCacNV(nvs);
        Console.WriteLine(XuatTTCacNV(nvs));

        Console.WriteLine("\nNhân viên lương từ 5tr-7tr:");
        Console.WriteLine(XuatTTCacNV(LocNVTheoLuong(nvs, 5000000, 7000000)));

        Console.ReadLine();
    }
}