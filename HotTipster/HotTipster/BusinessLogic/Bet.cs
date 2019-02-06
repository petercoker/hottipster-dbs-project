﻿using System;

namespace HotTipster
{
    public class Bet 
    {
        public int BetID { get; set; }
        public string RaceCourseName { get; set; }
        public string HorseName { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public bool Result { get; set; }

        public Bet() 
        {}

        public Bet(int betID, string raceCourseName,
            string horseName, DateTime date,
            decimal amount, bool result)
        {
            BetID = betID;
            RaceCourseName = raceCourseName;
            HorseName = horseName;
            Date = date;
            Amount = amount;
            Result = result;
        }

        

        public override string ToString()
        {
            return $"{nameof(BetID)}: {BetID}{Environment.NewLine}" +
                   $"{nameof(RaceCourseName)}: {RaceCourseName}{Environment.NewLine}" +
                   $"{nameof(HorseName)}: {HorseName}{Environment.NewLine}" +
                   $"{nameof(Date)}: {Date}{Environment.NewLine}" +
                   $"{nameof(Amount)}: {Amount}{Environment.NewLine}" +
                   $"{nameof(Result)}: {Result}{Environment.NewLine}";
        }
    }
}
