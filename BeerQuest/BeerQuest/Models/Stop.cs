using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeerQuest.Models
{
    public class Stop
    {
        [Key]
        public int id { get; set; }
        
        public int businessId { get; set; }
        public bool complete { get; set; }
        public bool isFree { get; set; }
        public DateTime dateTime { get; set; }
        [ForeignKey("Member")]
        public int memberID { get; set; }
        public Member member { get; set; }
        [ForeignKey("Business")]
        public int businessID { get; set; }
        public Business business { get; set; }



    }
}