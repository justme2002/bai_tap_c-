namespace bt.bai1;

public class Engineer : Employee
{
  public string? Major { get; set; }

  public Engineer()
  {
    
  }
  
  public Engineer(string Name, int Age, int Gender, string Address, string Major) : base(Name, Age, Gender, Address)
  {
    this.Major = Major;
  }

  public override Object getInfomation() 
  {
    return new {
      Name = this.Name,
      Age = this.Age,
      Gender = this.Gender,
      Address = this.Address,
      Major = this.Major  
    };
  }
}