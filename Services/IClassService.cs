using OnThiGK.Models;
namespace OnThiGK.Service{

    public interface IClassService{
        List<Class> GetClasses();
        public Class? getClassById(int id);
        void CreateClass(Class class1);
        void UpdateClass(Class class1);

        void DeleteClass(int id);

        List<School> GetSchools();
    
    }
    
}