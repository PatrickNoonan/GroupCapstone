using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeerQuest.Models
{
    public class Business
    {
        [Key]
        public int Id { get; set; }

        public string Address { get; set; }
        public bool Premium { get; set; }
        public bool IsFree { get; set; }
        public string Name { get; set; }
        //[ForeignKey("ApplicationUser")]
        //public string ApplicationId { get; set; }
        //public ApplicationUser ApplicationUser { get; set; }

    }
}