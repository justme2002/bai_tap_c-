namespace bt.bai3;

public class B : Student
{
  public const string MATH = "Math";
  public const string BIOLOGY = "Biology";
  public const string CHEMISTRY = "Chemistry";

  public B() : base()
  {

  }

  public B(int Id, string Name, string Address, int PrivilegeLevel) : base(Id, Name, Address, PrivilegeLevel)
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
        Math = MATH,
        Biology = BIOLOGY,
        Chemistry = CHEMISTRY,
      }
    );
  }
}