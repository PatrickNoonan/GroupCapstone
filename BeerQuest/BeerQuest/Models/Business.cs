using System;
using System.ComponentModel.DataAnnotations;

namespace BeerQuest.Models
{
    public class Business
    {
        [Key]
        public int id { get; set; }

        public string address { get; set; }
        public double points { get; set; }
        public string name { get; set; }
        public List<Stop> stops { get; set; }
    }
}