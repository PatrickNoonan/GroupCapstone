using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Passport : IEnumerable
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("StopOne")]
        public int StopOneId { get; set; }
        public Stop StopOne { get; set; }
        [ForeignKey("StopTwo")]
        public int StopTwoId { get; set; }
        public Stop StopTwo { get; set; }
        [ForeignKey("StopThree")]
        public int StopThreeId { get; set; }
        public Stop StopThree { get; set; }
        [ForeignKey("StopFour")]
        public int StopFourId { get; set; }
        public Stop StopFour { get; set; }
        [ForeignKey("StopFive")]
        public int? StopFiveId { get; set; }
        public virtual Stop StopFive { get; set; }
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
