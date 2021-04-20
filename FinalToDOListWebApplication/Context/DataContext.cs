using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalToDOListWebApplication.Model;

namespace FinalToDOListWebApplication.Context
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {

        }
        public DbSet<ToDoList> ToDos { get; set; }
    }
   
}
