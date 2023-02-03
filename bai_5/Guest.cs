namespace bt.bai5;

public class Guest
{
  public string? Name { get; set; }
  public int Age { get; set; }
  public long CivilId { get; set; }

  public Guest(string Name, int Age, long CivilId)
  {
    this.Name = Name;
    this.Age = Age;
    this.CivilId = CivilId;
  }

  public Guest()
  {

  }
}

