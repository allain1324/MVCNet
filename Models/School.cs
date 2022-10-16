namespace OnThiGK.Models;
using System.ComponentModel.DataAnnotations;
public class School{
    public School(){
        Classes = new List<Class>();
    }
    [Key]
    public int Id { get; set; }
    public string NameSchool { get; set; } 

    public List<Class> Classes { get; set; }


}