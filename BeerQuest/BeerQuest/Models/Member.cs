using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeerQuest.Models
{
    public class Member
    {
        [Key]
        public int id { get; set; }

        public string title { get; set; }
        public double points { get; set; }
        public string name { get; set; }
        public List<Stop> stops{ get; set; }
        [ForeignKey("ApplicationUser")]
        public string ApplicationId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}