using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Date")]
        public DateTime date { get; set; }

        [Display(Name = "Party Type")]
        public PartyType partyType { get; set; }

        [Display(Name = "Number of Attendees")]
        public int attendees { get; set; }

        [Display(Name = "Duration")]
        [Range(1, 4)]
        public int duration { get; set; }

    }
     
    public enum PartyType
    {
        Dinner,
        Birthday,
        Cocktail,
        Business
    }
}