namespace OnThiGK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Class{
    public Class(){
        Students = new List<Student>();
    }
    
    [Key]
    public int Id { get; set; }
    public string NameClass { get; set; } 


    [ForeignKey("School")]
    public int SchoolId {get;set;}
    public School School { get; set; }
    public List<Student> Students { get; set; }


}