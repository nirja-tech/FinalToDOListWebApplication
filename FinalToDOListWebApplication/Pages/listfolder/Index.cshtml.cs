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
    public class IndexModel : PageModel
    {
        private readonly FinalToDOListWebApplication.Context.DataContext _context;

        public IndexModel(FinalToDOListWebApplication.Context.DataContext context)
        {
            _context = context;
        }

        public IList<ToDoList> ToDoList { get;set; }

        public async Task OnGetAsync()
        {
            ToDoList = await _context.ToDos.ToListAsync();
        }
    }
}
