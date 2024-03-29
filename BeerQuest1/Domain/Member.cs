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
        [ForeignKey("ApplicationUser")]
        public string ApplicationId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public ApplicationRole ApplicationRole { get; set; }
        public string UserRole { get; set; }
        public int? PassportId { get; set; }
        [ForeignKey("PassportId")]
        public virtual Passport Passport { get; set; }
        public int? RankId { get; set; }
        [ForeignKey("RankId")]
        public Rank Rank { get; set; }

    }
}