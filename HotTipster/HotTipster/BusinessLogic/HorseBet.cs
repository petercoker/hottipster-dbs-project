using System;

namespace HotTipster
{
    public class HorseBet 
    {
        public string RaceCourse { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public bool Result { get; set; }

        public HorseBet() 
        {}

        public HorseBet(string raceCourse, DateTime date,
            decimal amount, bool result)
        {
            RaceCourse = raceCourse;
            Date = date;
            Amount = amount;
            Result = result;
        }
        
    }
}
