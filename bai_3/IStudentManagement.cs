namespace bt.bai3;

public interface IStudentManagement
{
  public void AddStudent(string group, string name, string address, int PrivilegeLevel);
  public void DisplayStudent();
  public void FindStudentById(int id);
}