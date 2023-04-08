using Domain.Common;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Domain.Entities
{
    public class Note : EntityBase<Guid>
    {
        public string? Title { get; set; }
        public string Content { get; set; }
        public string UserId { get; set; }

        public int NoteCategoryId { get; set; }

     








        //Many to many


        public ICollection<NoteCategory> NoteCategories { get; set; }

        






    }
}
