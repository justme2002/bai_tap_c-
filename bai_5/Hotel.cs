namespace bt.bai5;

public class Hotel
{
  public List<Room> Rooms { get; set; }
  public GuestManagement guestManagement { get; set; }

  public Hotel()
  {
    this.Rooms = new List<Room>();
    this.guestManagement = new GuestManagement();
  }

  public int caculateRentDay(int day, string type)
  {
    if (type == "A")
    {
      return day * RoomType.A;
    }

    if (type == "B")
    {
      return day * RoomType.B;
    }

    if (type == "C")
    {
      return day * RoomType.C;
    }

    return 0;
  }

  public void addGuestToRoom(string name, int age, long CivilId, string RoomType)
  {
    this.guestManagement!.addGuest(name, age, CivilId);
    if (RoomType == "A")
    {
      this.Rooms!.Add(new Room
        {
          RoomType = "A",
          RentDay = new Random().Next(30),
          Guest = guestManagement!.findGuestToRent(CivilId)
        }
      );
      this.displayRoom();
    }
    if (RoomType == "B")
    {
      this.Rooms!.Add(new Room
        {
          RoomType = "B",
          RentDay = new Random().Next(30),
          Guest = guestManagement!.findGuestToRent(CivilId)
        }
      );
      this.displayRoom();
    }
    if (RoomType == "C")
    {
      this.Rooms!.Add(new Room
        {
          RoomType = "C",
          RentDay = new Random().Next(30),
          Guest = guestManagement!.findGuestToRent(CivilId)
        }
      );
      this.displayRoom();
    }
  }
  public void displayRoom()
  {
    foreach (var item in this.Rooms!)
    {
      System.Console.WriteLine(new {
        RentDay = item.RentDay,
        RoomType = item.RoomType, 
        GuestId = item.Guest!.CivilId
      });
    }
  }

  public void caculatePriceByCivilId(long civilId, string roomType)
  {
    Room room = this.Rooms!.Find(room => room.Guest!.CivilId == civilId)!;
    int rentDay = this.caculateRentDay(room.RentDay, roomType);
    System.Console.WriteLine(rentDay);
  }
}