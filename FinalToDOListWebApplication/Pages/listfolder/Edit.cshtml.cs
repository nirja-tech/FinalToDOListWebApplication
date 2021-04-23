using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalToDOListWebApplication.Context;
using FinalToDOListWebApplication.Model;

namespace FinalToDOListWebApplication.Pages.list
{
    public class EditModel : PageModel
    {
        private readonly FinalToDOListWebApplication.Context.DataContext _context;

        public EditModel(FinalToDOListWebApplication.Context.DataContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ToDoList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ToDoListExists(ToDoList.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ToDoListExists(int id)
        {
            return _context.ToDos.Any(e => e.ID == id);
        }
    }
}
