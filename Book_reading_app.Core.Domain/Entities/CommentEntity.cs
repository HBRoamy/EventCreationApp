using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book_reading_app.Core.Domain.Entities
{
    public class CommentEntity
    {
        [ForeignKey("BookEventEntity")]
        public int Id { get; set; }
        public string PostingUserEmail { get; set; }

        [Required(ErrorMessage = "Please write a comment before posting")]
        public string Comment { get; set; }

        public int EventId { get; set; } //event where it was posted

        [DataType(DataType.Date)]
        public DateTime TimeStamp { get; set; }
    }
}