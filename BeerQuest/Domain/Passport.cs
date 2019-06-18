using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    class Passport
    {
        [Key]
        public int Id { get; set; }
        public Stop StopOne { get; set; }
        public Stop StopTwo { get; set; }
        public Stop StopThree { get; set; }
        public Stop StopFour { get; set; }
        public Stop StopFive { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StopDate { get; set; }
        public int CurrentStop { get; set; }
    }
}
