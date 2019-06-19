using Domain;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Stop
    {
        [Key]
        public int Id { get; set; }
        public bool Complete { get; set; }
        public bool IsFree { get; set; }
        public float lat { get; set; }
        public float lng { get; set; }
        public DateTime CheckInDate { get; set; }
        [ForeignKey("Member")]
        public int MemberID { get; set; }
        public Member Member { get; set; }
        [ForeignKey("Business")]
        public int BusinessID { get; set; }
        public Business Business { get; set; }

    }
}