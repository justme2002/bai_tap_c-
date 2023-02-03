namespace bt.bai4;

public class HoGiaDinh 
{
  public int SoThanhVien { get; set; }
  public int SoNha { get; set; }
  public List<Nguoi>? Nguois { get; set; }

  public HoGiaDinh()
  {

  }

  public HoGiaDinh(int SoThanhVien, int SoNha)
  {
    this.SoThanhVien = SoThanhVien;
    this.SoNha = SoNha;
    this.Nguois = Nguois;
  }

  public void XuatHoGiaDinh()
  {
    System.Console.WriteLine("Ho gia dinh");
    System.Console.WriteLine(new {
      SoThanhVien = Nguois!.Count,
      SoNha = this.SoNha
    });
    System.Console.WriteLine("Cac Thanh Vien");
    foreach (var item in this.Nguois!)
    {
      item.xuatThongTinNguoi();
    }
  }
}