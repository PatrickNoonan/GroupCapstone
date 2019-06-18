using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Member
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public double Points { get; set; }
        public string Name { get; set; }
        public bool ActivePassport { get; set; }
        //public List<Stop> Stops{ get; set; }
        [ForeignKey("ApplicationUser")]
        public string ApplicationId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public ApplicationRole ApplicationRole { get; set; }
    }
}