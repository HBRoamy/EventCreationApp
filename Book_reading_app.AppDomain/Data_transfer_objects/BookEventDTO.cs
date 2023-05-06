using Book_reading_app.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Book_reading_app.AppDomain.Data_transfer_objects
{
    public class BookEventDTO
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5)]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Event Date")]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Location for Event")]
        public string Location { get; set; }

        [Required]
        [Display(Name = "Event Starting @")]
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }

        [Display(Name = "Is it a private event? (public by default)")]
        public bool IsPrivateEvent { get; set; } = false; // default is public I guess

        [Range(1, 4, ErrorMessage = " Duration should be 1-4 hours only")]
        [Display(Name = "Duration Of Event (in Hours)")]
        public int? DurationInHours { get; set; } = 1;

        [StringLength(50)]
        [Display(Name = "Event Description")]
        public string Description { get; set; }

        [StringLength(500)]
        [Display(Name = "Other Details")]
        public string OtherDetails { get; set; }

        [Display(Name = "Invite By Email (seperate using comma)")]
        public string InviteByEmail { get; set; }

        [ForeignKey("EventId")]
        public ICollection<CommentEntity> Comments { get; set; }

        [DataType(DataType.EmailAddress)]
        public string OrganisersEmail { get; set; } // it will help in getting events made by every individual user
    }
}
