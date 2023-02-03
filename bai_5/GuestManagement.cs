namespace bt.bai5;

public class GuestManagement
{
  public List<Guest>? Guests { get; set; }

  public GuestManagement()
  {
    this.Guests = new List<Guest>
    {
      new Guest 
      {
        Name = "Huy",
        Age = 18,
        CivilId = 044202000460
      }
    };
  }
  
  public void addGuest(string name, int age, long civilId)
  {
    this.Guests!.Add(new Guest(Name: name, Age: age, CivilId: civilId));
  }

  public void displayGuests()
  {
    foreach (var item in this.Guests!)
    {
      System.Console.WriteLine(
        new {
          Name = item.Name,
          Age = item.Age,
          CivilId = item.CivilId
        }
      );
    }
  }

  public Guest findGuestToRent(long CivilId)
  {
    return this.Guests!.Where(Guest => Guest.CivilId == CivilId).First();
  }

  public void deleteGuest(long civilId)
  {
    Guest findGuest = this.Guests!.Where(guest => guest.CivilId == civilId).First();
    this.Guests!.Remove(findGuest);
  }
}