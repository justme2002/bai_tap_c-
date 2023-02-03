//Student (Id, Name, Address, privilege)
  //A (Math, Phys, Chem)
  //B (Math, Chem, Bio)
  //C (Lit, His, Geo)

using bt.bai3;

public class Program
{
  public static void Main(string[]args)
  {
    StudentManagement studentManagement = new StudentManagement();

    while (true)
    {
      System.Console.WriteLine("1: Add new student");
      System.Console.WriteLine("2: Display students");
      System.Console.WriteLine("3: Find student by Id");
      System.Console.WriteLine("4: Exit");

      System.Console.WriteLine("Give a choice");
      int choice = Int32.Parse(Console.ReadLine()!);
      switch (choice)
      {
        case 1:
          System.Console.WriteLine("Insert group: ");
          string group = Console.ReadLine()!;

          System.Console.WriteLine("Name: ");
          string name = Console.ReadLine()!;
          System.Console.WriteLine("Address: ");
          string address = Console.ReadLine()!;
          System.Console.WriteLine("PrivilegeLevel: ");
          int PrivilegeLevel = Int32.Parse(Console.ReadLine()!);

          studentManagement.AddStudent(group, name, address, PrivilegeLevel);
        break;

        case 2:
          System.Console.WriteLine("display student");
          studentManagement.DisplayStudent();
        break;

        case 3:
          System.Console.WriteLine("Find student");
          int id = Int32.Parse(Console.ReadLine()!);
          studentManagement.FindStudentById(id);
        break;
      }
    }
  }
}