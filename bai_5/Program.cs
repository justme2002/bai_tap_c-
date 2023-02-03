/* 
  Khach san
    khach hang -> thuePhong (so ngay thue, loai phong, thong tin ca nhan)
    loai phong (A, B, C)
    Khanh hang (Ho ten, Tuoi, CMND)
*/

using bt.bai5;

public class Program
{
  public static void Main(string[] args)
  {
    Hotel hotel = new Hotel();
    GuestManagement guestManagement = new GuestManagement();
    
    while (true)
    {
      System.Console.WriteLine("1: Create procedure for the guest to rent room");
      System.Console.WriteLine("2: Remove guest");
      System.Console.WriteLine("3: Calculate fee");

      int choice = Int32.Parse(Console.ReadLine()!);

      switch (choice)
      {
        case 1:
          guestManagement.displayGuests();
          System.Console.WriteLine("Name: ");
          string name = Console.ReadLine()!;
          System.Console.WriteLine("Age: ");
          int age = Int32.Parse(Console.ReadLine()!);
          System.Console.WriteLine("Civil_Id: ");
          long civilId = Int64.Parse(Console.ReadLine()!);
          System.Console.WriteLine("Type: ");
          string type = Console.ReadLine()!;

          hotel.addGuestToRoom(name, age, civilId, type);
        break;


        case 3:
          System.Console.WriteLine("Civil_Id: ");
          long Id = Int64.Parse(Console.ReadLine()!);
          System.Console.WriteLine("RoomType: ");
          string roomType = Console.ReadLine()!;

          hotel.caculatePriceByCivilId(Id, roomType);
        break;
      }
    }
  }  
}