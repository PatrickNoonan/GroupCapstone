using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace Domain
{
    public class Passport : IEnumerable
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

        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index < CurrentStop; index++)
            {
                if (CurrentStop >= 1)
                {
                    yield return StopOne;
                }
                if (CurrentStop >= 2)
                {
                    yield return StopTwo;
                }
                if (CurrentStop >= 3)
                {
                    yield return StopThree;
                }
                if (CurrentStop >= 4)
                {
                    yield return StopFour;
                }
                if (CurrentStop == 5)
                {
                    yield return StopFive;
                }
            }
        }
    }
}
