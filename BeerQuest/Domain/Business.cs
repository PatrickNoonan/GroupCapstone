using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Business
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public bool Premium { get; set; }
        public int Pin { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }
        [ForeignKey("ApplicationUser")]
        public string ApplicationId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public ApplicationRole ApplicationRole { get; set; }
        public string UserRole { get; set; }
        public int CheckIns { get; set; }

    }
}