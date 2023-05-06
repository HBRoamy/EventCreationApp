using Book_reading_app.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_reading_app.Core.Web.Models
{
    public class EventDetailsViewModel
    {
        public IEnumerable<BookEventEntity> AllBookEvents { get; set; }
        public IEnumerable<BookEventEntity> AllPublicBookEvents { get; set; }
        public IEnumerable<CommentEntity> Comments { get; set; }
    }
}
