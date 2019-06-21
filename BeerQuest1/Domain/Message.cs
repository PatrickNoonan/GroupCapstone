using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain
{
   public class Message
    {
        [Key]
        public int ID { get; set; }
        public string CurrentRank { get; set; }
        public string CurrentMember { get; set; }
        public string CurrentBar { get; set; }
        public DateTime CurrentDay { get; set; }
        public bool WasFree { get; set; }
    }
}
