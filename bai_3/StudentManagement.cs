namespace bt.bai3;

public class StudentManagement : IStudentManagement
{

  public List<Student>? Students { get; set; }
  
  public StudentManagement()
  {
    this.Students = new List<Student>
    {
      new A
      {
        Id = 1,
        Name = "Nam",
        Address = "Da nang",
        PrivilegeLevel = 1
      },
      new B
      {
        Id = 2,
        Name = "Tuan",
        Address = "Quang Tri",
        PrivilegeLevel = 2
      },
      new C
      {
        Id = 3,
        Name = "Linh",
        Address = "Quang Binh",
        PrivilegeLevel = 3
      }
    };
  }

  public void AddStudent(string group, string name, string address, int PrivilegeLevel)
  {
    if (group == "A")
    {
      this.Students!.Add(new A {
        Name = name,
        Address = address,
        Id = (Int32) new Random().NextInt64(),
        PrivilegeLevel = PrivilegeLevel
      });

      this.DisplayStudent();
    }

    if (group == "B")
    {
      this.Students!.Add(new B {
        Name = name,
        Address = address,
        Id = (Int32) new Random().NextInt64(),
        PrivilegeLevel = PrivilegeLevel
      });

      this.DisplayStudent();
    }

    if (group == "C")
    {
      this.Students!.Add(new C {
        Name = name,
        Address = address,
        Id = (Int32) new Random().NextInt64(),
        PrivilegeLevel = PrivilegeLevel
      });

      this.DisplayStudent();
    }
  }

  public void DisplayStudent()
  {
    foreach (var item in Students!)
    {
      item.getInfomation();
    }
  }

  public void FindStudentById(int id)
  {
    var findById = from student in this.Students where student.Id == id select student;
    System.Console.WriteLine(findById.First().Name);
  }   
}