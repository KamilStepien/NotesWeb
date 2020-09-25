using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Notes.Models.EFModels;


namespace Notes.Contexts
{
    public class ApplicationDBContext:DbContext
    {

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> option) : base(option) { }

        public DbSet<Note> Notes { get; set; }


    }
}
