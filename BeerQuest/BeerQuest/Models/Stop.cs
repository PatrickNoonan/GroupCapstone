using System;
using System.ComponentModel.DataAnnotations;

namespace BeerQuest.Models
{
    public class Stop
    {
        [Key]
        public int id { get; set; }
        public int userId { get; set; }
        public int businessId { get; set; }
        public bool complete { get; set; }
        public bool isFree { get; set; }
        public DateTime dateTime { get; set; }

    }
}