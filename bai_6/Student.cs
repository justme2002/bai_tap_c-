namespace bt.bai6;

public class Student
{
  public string? Name { get; set; }
  public int Age { get; set; }
  public string? HomeTown { get; set; }
  public string? Class { get; set; }

  public Student()
  {
    
  }

  public Student(string Name, int Age, string HomeTown, string Class)
  {
    this.Name = Name;
    this.Age = Age;
    this.HomeTown = HomeTown;
    this.Class = Class;
  }
}