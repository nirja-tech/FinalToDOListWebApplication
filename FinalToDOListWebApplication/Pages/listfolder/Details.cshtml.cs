using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalToDOListWebApplication.Context;
using FinalToDOListWebApplication.Model;

namespace FinalToDOListWebApplication.Pages.list
{
    public class DetailsModel : PageModel
    {
        private readonly FinalToDOListWebApplication.Context.DataContext _context;

        public DetailsModel(FinalToDOListWebApplication.Context.DataContext context)
        {
            _context = context;
        }

        public ToDoList ToDoList { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ToDoList = await _context.ToDos.FirstOrDefaultAsync(m => m.ID == id);

            if (ToDoList == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
