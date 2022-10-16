using OnThiGK.Models;
using Microsoft.EntityFrameworkCore;

namespace OnThiGK.Service
{
  public class ClassService : IClassService
  {

    private readonly OnThiGKContext _context;

    public ClassService(OnThiGKContext context){
        _context = context;
    }
    public void CreateClass(Class class1)
    {
        _context.Classes.Add(class1);
        _context.SaveChanges();
    }

    public void DeleteClass(int id)
    {
      var existedProduct = getClassById(id);
      if(existedProduct == null){
          return;
      }
      _context.Classes.Remove(existedProduct);
      _context.SaveChanges();
    }

    public Class? getClassById(int id)
    {
      return _context.Classes.FirstOrDefault(p=> p.Id == id);
    }

    public List<Class> GetClasses()
    {
      return _context.Classes.Include(x=> x.School).ToList() as List<Class>;
    }

    public List<School> GetSchools()
    {
      return _context.Schools.ToList() as List<School>;
    }

    public void UpdateClass(Class class1)
    {
      var existedProduct =  getClassById(class1.Id);
      if(existedProduct == null){
          return;
      }
      existedProduct.NameClass = class1.NameClass;
      existedProduct.SchoolId = class1.SchoolId;
      _context.Update(existedProduct);
      _context.SaveChanges();
    }
  }
}