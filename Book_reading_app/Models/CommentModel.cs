using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Book_reading_app.Core.Web.Models
{
    public class CommentModel
    {
       
        public string PostingUserEmail { get; set; }

        [Required(ErrorMessage = "Please write a comment before posting")]
        public string Comment { get; set; }

        public int EventId { get; set; } //event where it was posted

        [DataType(DataType.Date)]
        public DateTime TimeStamp { get; set; }

        
    }
}
