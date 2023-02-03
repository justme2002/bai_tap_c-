//employee (name, age, gender, address)
  //Worker extends from employee with level 1 - 10
  //Engineer extends from employee with major
  //Staff extends from employee with current job

namespace bt.bai1;

public class Employee {
  public string? Name { get; set; }
  public int Age { get; set; }
  public int Gender { get; set; }
  public string? Address { get; set; }

  public Employee()
  {

  }

  public Employee(string Name, int Age, int Gender, string Address)
  {
    this.Name = Name;
    this.Age = Age;
    this.Gender = Gender;
    this.Address = Address;
  }

  public virtual Object getInfomation()
  {
    return new {};
  }
}