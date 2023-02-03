namespace bt.bai1;

public class Staff : Employee
{
  public string? Job { get; set; }

  public Staff()
  {
    
  }
  
  public Staff(string Name, int Age, int Gender, string Address, string Job) : base(Name, Age, Gender, Address)
  {
    this.Job = Job;
  }

  public override Object getInfomation() 
  {
    return new {
      Name = this.Name,
      Age = this.Age,
      Gender = this.Gender,
      Address = this.Address,
      Job = this.Job 
    };
  }
}