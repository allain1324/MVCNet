using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnThiGK.Models;
using Microsoft.AspNetCore.Mvc;
using OnThiGK.Service;
namespace OnThiGK.Controllers
{
    public class ClassController : Controller
    {
      
        private readonly IClassService classService;

        public ClassController(IClassService classService)
        {
            this.classService = classService;

            // var categorys = new List<string>(){
            //     "smartphone",
            //     "TV"
            // };
            // ViewBag.categories = categorys;

        }
        public IActionResult Index()
        {
            var Classes = classService.GetClasses();
            return View(Classes);
        }
        public IActionResult Create()
        {
            var Class = classService.GetSchools();
            return View(Class);
        }
        public IActionResult Save(Class class1){
            var existedClass = classService.getClassById(class1.Id);
            if(existedClass == null){
            classService.CreateClass(class1);

            }else{
            classService.UpdateClass(class1);

            }

            return RedirectToAction("Index");
        }

        public IActionResult Update(int id){
            var class1 = classService.getClassById(id);
            if(class1 == null){
                return RedirectToAction("Create");
            }
            var schools = classService.GetSchools();
            ViewBag.Class = class1;
            return View(schools);
        }
        public IActionResult Delete(int id){
            classService.DeleteClass(id);
            return RedirectToAction("Index");

        }
        
     
    }
}