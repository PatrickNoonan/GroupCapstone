using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Business
    {
        [Key]
        public int Id { get; set; }

        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public bool Premium { get; set; }
        public bool IsFree { get; set; }
        public string Name { get; set; }
        public int Pin { get; set; }
        //[ForeignKey("ApplicationUser")]
        //public string ApplicationId { get; set; }
        //public ApplicationUser ApplicationUser { get; set; }

    }
}