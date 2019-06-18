using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain
{
   public class Message
    { [Key]
    public int ID { get; set; }

        public Member CurrentMember { get; set; }
        public Stop CurrentBar { get; set; }
        public DateTime CurrentDay { get; set; }
    }
}
