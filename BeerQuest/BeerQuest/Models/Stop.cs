using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeerQuest.Models
{
    public class Stop
    {
        [Key]
        public int Id { get; set; }
        
        public int BusinessId { get; set; }
        public bool Complete { get; set; }
        public bool IsFree { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public DateTime DateTime { get; set; }
        [ForeignKey("Member")]
        public int MemberID { get; set; }
        public Member Member { get; set; }
        [ForeignKey("Business")]
        public int BusinessID { get; set; }
        public Business Business { get; set; }



    }
}