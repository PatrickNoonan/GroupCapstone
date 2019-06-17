using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeerQuest.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }

        public string title { get; set; }
        public double points { get; set; }
        public string name { get; set; }
        public List<Stop> stops{ get; set; }
    }
}