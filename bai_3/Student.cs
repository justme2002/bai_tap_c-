namespace bt.bai3;

public abstract class Student
{
  public int Id { get; set; }
  public string? Name { get; set; }
  public string? Address { get; set; }
  public int PrivilegeLevel { get; set; }

  public Student() : base()
  {

  }

  public Student (int Id, string Name, string Address, int PrivilegeLevel)
  {
    this.Id = Id;
    this.Name = Name;
    this.Address = Address;
    this.PrivilegeLevel = PrivilegeLevel;
  }

  public abstract void getInfomation();
}