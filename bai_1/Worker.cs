namespace bt.bai1;

public class Worker : Employee
{
  public int Level { get; set; }

  public Worker()
  {
    
  }
  
  public Worker(string Name, int Age, int Gender, string Address, int Level) : base(Name, Age, Gender, Address)
  {
    this.Level = Level;
  }

  public override Object getInfomation() 
  {
    return new {
      Name = this.Name,
      Age = this.Age,
      Gender = this.Gender,
      Address = this.Address,
      Level = this.Level
    };
  }
}