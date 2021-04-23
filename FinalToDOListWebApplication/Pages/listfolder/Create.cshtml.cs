using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FinalToDOListWebApplication.Context;
using FinalToDOListWebApplication.Model;

namespace FinalToDOListWebApplication.Pages.list
{
    public class CreateModel : PageModel
    {
        private readonly FinalToDOListWebApplication.Context.DataContext _context;

        public CreateModel(FinalToDOListWebApplication.Context.DataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ToDoList ToDoList { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ToDos.Add(ToDoList);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
