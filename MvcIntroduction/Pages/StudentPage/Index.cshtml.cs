using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MvcIntroduction.Entites;
using MvcIntroduction.Models;

namespace MvcIntroduction.Pages.StudentPage
{
    public class IndexModel : PageModel
    {
        private readonly SchoolContext _context;
        public IndexModel(SchoolContext context)
        {
            _context = context;
        }
        public List<Student> Students { get; set; }
        public void OnGet(string search)
        {
            if (String.IsNullOrEmpty(search))
            {
                Students = _context.Students.ToList();
            }
            else
            {
                Students = _context.Students.Where(s => s.FirstName.Contains(search)).ToList();
            }

        }
        [BindProperty]
        public Student Student { get; set; }
        public IActionResult OnPost()
        {
            _context.Students.Add(Student);
            _context.SaveChanges();
            return RedirectToPage("/studentpage/index");
        }
    }
}
