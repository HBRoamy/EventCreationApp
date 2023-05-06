using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Book_reading_app.AppDomain.Data_transfer_objects
{
    public class CommentDTO
    {
        //public int Id { get; set; }
        public string PostingUserEmail { get; set; }

        [Required(ErrorMessage = "Please write a comment before posting")]
        public string Comment { get; set; }

        public int EventId { get; set; } //event where it was posted

        [DataType(DataType.Date)]
        public DateTime TimeStamp { get; set; }
    }
}
