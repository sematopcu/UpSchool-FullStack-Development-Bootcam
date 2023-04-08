using Domain.Common;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Domain.Entities
{
    public class NoteCategory:EntityBase<Guid>
    {
        public Guid NoteId { get; set; }
        public Note Note { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

       

       

        
       


    }
}
