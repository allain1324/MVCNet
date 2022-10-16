using OnThiGK.Models;
namespace OnThiGK.Service{

    public interface IStudentService{
        List<Student> GetStudents();

        public List<Student>? getStudentByClassId(int id);
        public Student? getStudentById(int id);
        void CreateStudent(Student student);
        void UpdateStudent(Student student);

        void DeleteStudent(int id);
    
    }
    
}