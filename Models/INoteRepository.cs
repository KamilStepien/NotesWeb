using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Notes.Models.EFModels;

namespace Notes.Models
{
    public interface INoteRepository
    {
        Note GetNote();
    }
}
