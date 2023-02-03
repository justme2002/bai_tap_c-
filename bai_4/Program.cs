// KhuPho (HoGiaDinh)
// HoGiaDinh (SoThanhVien, SoNha)
// Nguoi (HoTen, Tuoi, NgheNghiep, CMND)

using bt.bai4;

public class Program
{
  public static void Main(string[] args)
  {
    KhuPho khuPho = new KhuPho();
    
    while (true)
    {
      System.Console.WriteLine("1: Xuat thong tin khu pho");
      System.Console.WriteLine("2: Loc so luong ho gia dinh trong khu pho");
      int choice = Int32.Parse(Console.ReadLine()!);
      switch (choice)
      {
        case 1: 
          System.Console.WriteLine("Hien thi thong tin cac ho gia dinh trong khu pho");
          khuPho.xuatThongTinKhuPho();
        break;

        case 2:
          System.Console.WriteLine("Nhap so luong: ");
          int n = Int32.Parse(Console.ReadLine()!);
          khuPho.locSoLuongKhuPho(n);
        break;
      }
    }
  }
}