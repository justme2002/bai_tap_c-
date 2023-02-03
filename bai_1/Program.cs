using bt.bai1;

public class Program
{
  public static void Main()
  {

    EmployeeManagement employeeManagement = new EmployeeManagement();

    int choice = 0;
    while(true)
    {
      System.Console.WriteLine("1: Add Employee");
      System.Console.WriteLine("2: Find Employee by name");
      System.Console.WriteLine("3: Show employees");
      System.Console.WriteLine("4: Exit");

      choice = Int32.Parse(Console.ReadLine()!);
      System.Console.WriteLine($"Give a choice {choice}");

      if (choice == 4)
      {
        Environment.Exit(0);
      }      

      if (choice == 1)
      { 
        System.Console.WriteLine("position: ");
        string position = Console.ReadLine()!;
       
        System.Console.WriteLine("Name: ");
        string name = Console.ReadLine()!;
        System.Console.WriteLine("Age: ");
        int age = Int32.Parse(Console.ReadLine()!);
        System.Console.WriteLine("Gender: ");
        string gender = Console.ReadLine()!;
        System.Console.WriteLine("Address: ");
        string Address = Console.ReadLine()!;

        if (position.ToLower() == "worker")
        {
          System.Console.WriteLine("Level: ");
          int Level = Int32.Parse(Console.ReadLine()!);
          employeeManagement.addEmployee(new Worker {
            Name = name,
            Age = age,
            Gender = gender == "male" ? 0 : 1,
            Address = Address,
            Level = Level
          });

          employeeManagement.getEmployees();
        }

        if (position.ToLower() == "staff")
        {
          System.Console.WriteLine("Job: ");
          string Job = Console.ReadLine()!;
          employeeManagement.addEmployee(new Staff {
            Name = name,
            Age = age,
            Gender = gender == "male" ? 0 : 1,
            Address = Address,
            Job = char.ToUpper(Job[0]) + Job.Substring(1)
          });

          employeeManagement.getEmployees();
        }

        if (position.ToLower() == "engineer")
        {
          System.Console.WriteLine("Major: ");
          string Major = Console.ReadLine()!;
          employeeManagement.addEmployee(new Engineer {
            Name = name,
            Age = age,
            Gender = gender == "male" ? 0 : 1,
            Address = Address,
            Major = Major
          });

          employeeManagement.getEmployees();
        }

        
      }
      if (choice == 2)
      {
        string name = Console.ReadLine()!;
        List<Employee> result = employeeManagement.findEmployeeByName(name.ToLower());
        foreach (var item in result)
        {
          System.Console.WriteLine(
            new {
              Name = item.Name,
              Age = item.Age,
              Address = item.Address,
              Gender = item.Gender
            }
          );
        }
      }
      if (choice == 3)
      {
         employeeManagement.getEmployees();
      }
    }
  }
}
