namespace bt.bai3;

public class A : Student
{
  public const string MATH = "Math";
  public const string PHYSICS = "Physics";
  public const string CHEMISTRY = "Chemistry";

  public A() : base()
  {

  }

  public A(int Id, string Name, string Address, int PrivilegeLevel) : base(Id, Name, Address, PrivilegeLevel)
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
        Physics = PHYSICS,
        Chemistry = CHEMISTRY,
      }
    );
  }
}