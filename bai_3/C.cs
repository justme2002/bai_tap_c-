namespace bt.bai3;

public class C : Student
{
  public const string LITERATURE = "Literature";
  public const string HISTORY = "History";
  public const string GEOGRAPHY = "Geography";

  public C() : base()
  {

  }

  public C(int Id, string Name, string Address, int PrivilegeLevel) : base(Id, Name, Address, PrivilegeLevel)
  {
    
  }

  public override void getInfomation()
  {
    System.Console.WriteLine(
      new {
        Id = this.Id,
        Name = this.Name,
        Address = this.Address,
        PrivilegeLevel = this.PrivilegeLevel,
        Literature = LITERATURE,
        History = HISTORY,
        Geography = GEOGRAPHY
      }
    );
  }
}