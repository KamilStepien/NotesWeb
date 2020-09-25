using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Notes.Models.EFModels
{
    public class Note
    {
        public int NoteId { get; set; }
        public string Name { get; set; }
        public List<NoteListElementText> Data { get; set; }
    }


    public class NoteListElementText 
    {
        public int NoteListElementTextId { get; set  ; }
        public string Context { get ; set ; }

        public int NoteId { get; set; }

    }


}
