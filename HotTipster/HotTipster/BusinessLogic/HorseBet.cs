using System;

namespace HotTipster
{
    public class HorseBet 
    {
        public int BetID { get; set; }
        public string RacecourseName { get; set; }
        public string HorseName { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public bool Result { get; set; }

        public HorseBet() 
        {}

        public HorseBet(int betID, string racecourseName,
            string horseName, DateTime date,
            decimal amount, bool result)
        {
            BetID = betID;
            RacecourseName = racecourseName;
            HorseName = horseName;
            Date = date;
            Amount = amount;
            Result = result;
        }

        public HorseBet(int betID, string raceCourseName, string horseName, decimal amount, bool result)
        {
            BetID = betID;
            RacecourseName = raceCourseName;
            HorseName = horseName;
            Amount = amount;
            Result = result;
        }

        public override string ToString()
        {
            return $"{nameof(BetID)}: {BetID}{Environment.NewLine}" +
                   $"{nameof(RacecourseName)}: {RacecourseName}{Environment.NewLine}" +
                   $"{nameof(HorseName)}: {HorseName}{Environment.NewLine}" +
                   $"{nameof(Date)}: {Date}{Environment.NewLine}" +
                   $"{nameof(Amount)}: {Amount}{Environment.NewLine}" +
                   $"{nameof(Result)}: {Result}{Environment.NewLine}";
        }
    }
}
