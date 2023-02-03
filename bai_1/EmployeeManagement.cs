namespace bt.bai1;

public class EmployeeManagement
{
  public List<Employee>? Employees { get; set; }

  public EmployeeManagement()
  {
    this.Employees = new List<Employee>()
    {
      new Worker { 
        Name = "Nam", Age = 20, Gender = 0, Address = "QuangBinh", Level = 10
      },
      new Staff { 
        Name = "Linh", Age = 20, Gender = 1, Address = "QuangBinh", Job = "Accountant"
      },
      new Engineer { 
        Name = "Tuan", Age = 20, Gender = 0, Address = "QuangBinh", Major = "IT"
      }
    };
  }

  public void addEmployee(Employee employee)
  {
    this.Employees!.Add(employee);
  }

  public List<Employee> findEmployeeByName(string name)
  {
    return this.Employees!.Where(e => e.Name!.Contains(name)).ToList();
  }

  public void getEmployees()
  {
    foreach (var item in this.Employees!)
    {
      System.Console.WriteLine(item.getInfomation());
    }
  }
}