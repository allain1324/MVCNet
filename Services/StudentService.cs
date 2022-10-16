using OnThiGK.Models;
using Microsoft.EntityFrameworkCore;

namespace OnThiGK.Service
{
  public class StudentService : IStudentService
  {
    private readonly OnThiGKContext _context;

    public StudentService(OnThiGKContext context)
    {
      _context = context;
    }
    public void CreateStudent(Student student)
    {
      throw new NotImplementedException();
    }

    public void DeleteStudent(int id)
    {
      throw new NotImplementedException();
    }

    public List<Student>? getStudentByClassId(int id)
    {
      throw new NotImplementedException();
    }

    public Student? getStudentById(int id)
    {
      throw new NotImplementedException();
    }

    public List<Student> GetStudents()
    {
      throw new NotImplementedException();
    }

    public void UpdateStudent(Student student)
    {
      throw new NotImplementedException();
    }
  }
}