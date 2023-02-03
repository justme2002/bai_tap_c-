namespace bt.bai6;

public class StudentManagement
{
  public List<Student>? Students { get; set; }

  public StudentManagement()
  {
    this.Students = new List<Student>
    {
      new Student
      {
        Name = "Hoang Le Huy",
        Age = 20,
        Class = "20SE01",
        HomeTown = "Quangbinh"
      },
      new Student
      {
        Name = "Nguyen Hoai Nam",
        Age = 21,
        Class = "19IT",
        HomeTown = "Quangbinh"
      }
    };
  }

  public StudentManagement(List<Student> Students)
  {
    this.Students = Students;
  }

  public List<Student> AddStudent(Student student)
  {
    this.Students!.Add(student);
    return this.Students;
  }

  public void findStudentByAgeAndHomeTown(int? age, string? hometown = "")
  {
    if (hometown != "")
    {
      var getStudentByAgeAndHomeTown = from s in this.Students where s.Age == age & s.HomeTown == hometown select s;
      foreach (var item in getStudentByAgeAndHomeTown)
      {
        System.Console.WriteLine(new {
          Name = item.Name,
          Age = item.Age,
          Hometown = item.HomeTown,
          Class = item.Class
        });
      }
    } 

    var getStudentByAge = from s in this.Students where s.Age == age select s;
    foreach (var item in getStudentByAge)
    {
      System.Console.WriteLine(new {
        Name = item.Name,
        age = item.Age,
        Hometown = item.HomeTown,
        Class = item.Class 
      });
    }
  }
}