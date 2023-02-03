/*
- THPT -> quan ly [Ho so hoc sinh (Lop, hoc sinh)]
- hoc sinh (Ho ten, tuoi, que quan)
 */

 using bt.bai6;

 public class Program
 {
  public static void Main(string[]args)
  {
    StudentManagement studentManagement = new StudentManagement();
    studentManagement.findStudentByAgeAndHomeTown(20);
    List<Student> students = studentManagement.AddStudent(
      new Student 
      {
        Name = "Nguyen Tien Toan",
        Age = 20,
        Class = "21SE01",
        HomeTown = "Da nang"
      }
    );
    foreach (var item in students)
    {
      System.Console.WriteLine(item.Name);
    }
  }
 }