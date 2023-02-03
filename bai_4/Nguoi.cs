namespace bt.bai4;

public class Nguoi
{
  public string? HoTen { get; set; }
  public int Tuoi { get; set; }
  public string? NgheNghiep { get; set; }
  public long CMND { get; set; }

  public Nguoi()
  {

  }

  public Nguoi(string HoTen, int Tuoi, string NgheNghiep, long CMND)
  {
    this.HoTen = HoTen;
    this.Tuoi = Tuoi;
    this.NgheNghiep = NgheNghiep;
    this.CMND = CMND;
  }

  public void xuatThongTinNguoi()
  {
    System.Console.WriteLine(
      new {
        HoTen = this.HoTen,
        Tuoi = this.Tuoi,
        NgheNghiep = this.NgheNghiep,
        CMND = this.CMND
      }
    );
  }
}