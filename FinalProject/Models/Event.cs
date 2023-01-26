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
        public DateTime date { get; set; }
        public PartyType partyType { get; set; }
        public int attendees { get; set; }

        [Range(1, 8)]
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