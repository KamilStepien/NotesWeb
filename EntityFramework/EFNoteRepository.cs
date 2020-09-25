using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Notes.Models;
using Notes.Models.EFModels;
using Microsoft.EntityFrameworkCore;
using Notes.Contexts;

namespace Notes.EntityFramework
{
    public class EFNoteRepository : INoteRepository
    {
        private ApplicationDBContext _context;

        public EFNoteRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public Note GetNote()
        {
            throw new NotImplementedException();
        }
    }
}
