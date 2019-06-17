using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeerQuest.Models
{
    public class Business
    {
        [Key]
        public int id { get; set; }

        public string address { get; set; }
        public bool premium { get; set; }
        public bool isFree { get; set; }
        public string name { get; set; }
        [ForeignKey("ApplicationUser")]
        public string ApplicationId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

    }
}