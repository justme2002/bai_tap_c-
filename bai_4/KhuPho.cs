namespace bt.bai4;

public class KhuPho 
{
  public List<HoGiaDinh>? HoGiaDinhs { get; set; }

  public KhuPho ()
  {
    this.HoGiaDinhs = new List<HoGiaDinh>
    {
      new HoGiaDinh {
        Nguois = new List<Nguoi> {
          new Nguoi {
            HoTen = "NVA",
            CMND = 1234567789,
            NgheNghiep = "Can bo",
            Tuoi = 30
          },
          new Nguoi {
            HoTen = "NVB",
            CMND = 1235403234,
            NgheNghiep = "Cong an",
            Tuoi = 29
          }
        },
        SoNha = 99,
      },
      new HoGiaDinh {
        Nguois = new List<Nguoi> {
          new Nguoi {
            HoTen = "NVC",
            CMND = 1234567789,
            NgheNghiep = "Giao Vien",
            Tuoi = 30
          },
          new Nguoi {
            HoTen = "NVD",
            CMND = 1235403234,
            NgheNghiep = "Can Bo",
            Tuoi = 29
          }
        },
        SoNha = 99,
      },
      new HoGiaDinh {
        Nguois = new List<Nguoi> {
          new Nguoi {
            HoTen = "NVA",
            CMND = 1234567789,
            NgheNghiep = "Can bo",
            Tuoi = 30
          },
          new Nguoi {
            HoTen = "NVB",
            CMND = 1235403234,
            NgheNghiep = "Cong an",
            Tuoi = 29
          }
        },
        SoNha = 99,
      },
      new HoGiaDinh {
        Nguois = new List<Nguoi> {
          new Nguoi {
            HoTen = "NVC",
            CMND = 1234567789,
            NgheNghiep = "Giao Vien",
            Tuoi = 30
          },
          new Nguoi {
            HoTen = "NVD",
            CMND = 1235403234,
            NgheNghiep = "Can Bo",
            Tuoi = 29
          }
        },
        SoNha = 99,
      },
      new HoGiaDinh {
        Nguois = new List<Nguoi> {
          new Nguoi {
            HoTen = "NVA",
            CMND = 1234567789,
            NgheNghiep = "Can bo",
            Tuoi = 30
          },
          new Nguoi {
            HoTen = "NVB",
            CMND = 1235403234,
            NgheNghiep = "Cong an",
            Tuoi = 29
          }
        },
        SoNha = 99,
      },
      new HoGiaDinh {
        Nguois = new List<Nguoi> {
          new Nguoi {
            HoTen = "NVC",
            CMND = 1234567789,
            NgheNghiep = "Giao Vien",
            Tuoi = 30
          },
          new Nguoi {
            HoTen = "NVD",
            CMND = 1235403234,
            NgheNghiep = "Can Bo",
            Tuoi = 29
          }
        },
        SoNha = 99,
      },
      new HoGiaDinh {
        Nguois = new List<Nguoi> {
          new Nguoi {
            HoTen = "NVA",
            CMND = 1234567789,
            NgheNghiep = "Can bo",
            Tuoi = 30
          },
          new Nguoi {
            HoTen = "NVB",
            CMND = 1235403234,
            NgheNghiep = "Cong an",
            Tuoi = 29
          }
        },
        SoNha = 99,
      },
      new HoGiaDinh {
        Nguois = new List<Nguoi> {
          new Nguoi {
            HoTen = "NVC",
            CMND = 1234567789,
            NgheNghiep = "Giao Vien",
            Tuoi = 30
          },
          new Nguoi {
            HoTen = "NVD",
            CMND = 1235403234,
            NgheNghiep = "Can Bo",
            Tuoi = 29
          }
        },
        SoNha = 99,
      },
      new HoGiaDinh {
        Nguois = new List<Nguoi> {
          new Nguoi {
            HoTen = "NVA",
            CMND = 1234567789,
            NgheNghiep = "Can bo",
            Tuoi = 30
          },
          new Nguoi {
            HoTen = "NVB",
            CMND = 1235403234,
            NgheNghiep = "Cong an",
            Tuoi = 29
          }
        },
        SoNha = 99,
      },
      new HoGiaDinh {
        Nguois = new List<Nguoi> {
          new Nguoi {
            HoTen = "NVC",
            CMND = 1234567789,
            NgheNghiep = "Giao Vien",
            Tuoi = 30
          },
          new Nguoi {
            HoTen = "NVD",
            CMND = 1235403234,
            NgheNghiep = "Can Bo",
            Tuoi = 29
          }
        },
        SoNha = 99,
      }
    };
  }

  public void xuatThongTinKhuPho()
  {
    foreach (var item in this.HoGiaDinhs!)
    {
      item.XuatHoGiaDinh();
    }    
  }

  public void locSoLuongKhuPho(int n)
  {
    var loc = from s in this.HoGiaDinhs!.Take(n) select s;
    foreach (var item in loc)
    {
      item.XuatHoGiaDinh();
    }
  }
}