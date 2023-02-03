namespace bt.bai5;

public class Room
{
  public int RentDay { get; set; }
  public string? RoomType { get; set; }
  public Guest? Guest { get; set; }

  public Room()
  {
    
  }

  public Room(int RentDay, string RoomType, Guest Guest)
  {
    this.RentDay = RentDay;
    this.RoomType = RoomType;
    this.Guest = Guest;
  }
}