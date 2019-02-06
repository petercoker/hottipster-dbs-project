using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace HotTipster
{
    public class Bet : IComparable<Bet>
    {
        public int BetID { get; set; }
        public IEnumerable<string> RaceCourse { get; set; }
        public IEnumerable<string> HorseName { get; set; }
        public DateTime Date { get; set; }
        public decimal AmountWonOrLost { get; set; }
        public bool WinOrLost { get; set; }

        public Bet()
        {
            BetID = 0;
        }

        public Bet(int betID, IEnumerable<string> raceCourse,
            IEnumerable<string> horseName, DateTime date, 
            decimal amountWonOrLost, bool winOrLost)
        {
            BetID = betID;
            RaceCourse = raceCourse;
            HorseName = horseName;
            Date = date;
            AmountWonOrLost = amountWonOrLost;
            WinOrLost = winOrLost;
        }

        public int CompareTo(Bet otherBet)
        {
            if (otherBet == null)
            {
                return -1;
            }
            else
            {
                var compareRaceCourse = RaceCourse.CompareTo(otherBet.BetID);
                if (compareRaceCourse == 0)
                {
                    var compareHorseName = HorseName.CompareTo(otherBet.HorseName);
                    return compareHorseName != 0 ? compareHorseName : BetID.CompareTo(otherBet.BetID);
                }
                else
                {
                    return compareRaceCourse;
                }
            }

            
        }

        public override string ToString()
        {
            return $"{nameof(BetID)}: {BetID}{Environment.NewLine}" +
                   $"{nameof(RaceCourse)}: {RaceCourse}{Environment.NewLine}" +
                   $"{nameof(HorseName)}: {HorseName}{Environment.NewLine}" +
                   $"{nameof(Date)}: {Date}{Environment.NewLine}" +
                   $"{nameof(AmountWonOrLost)}: {AmountWonOrLost}{Environment.NewLine}" +
                   $"{nameof(WinOrLost)}: {WinOrLost}{Environment.NewLine}";

        }
    }
}
