using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotTipster.BusinessLogic
{
    public class BetRecords
    {
        public static List<Bet> LoadBetRecords()
        {
            var bet = new Bet();
            var betRecord = new List<Bet>();

            betRecord.Add(new Bet { BetID = 1, RaceCourseName = "Aintree", HorseName = "Cheetah", Date = DateTime.Parse("12/05/2017"), Amount = 11.58m, Result = true });
            betRecord.Add(new Bet { BetID = 2, RaceCourseName = "Punchestown", HorseName = "Thunder", Date = DateTime.Parse("22/12/2016"), Amount = 122.52m, Result = true });
            betRecord.Add(new Bet { BetID = 3, RaceCourseName = "Sandown", HorseName = "Flash", Date = DateTime.Parse("17/11/2016"), Amount = 20.00m, Result = false });
            betRecord.Add(new Bet { BetID = 4, RaceCourseName = "Ayr", HorseName = "Bloat", Date = DateTime.Parse("03/11/2016"), Amount = 25.00m, Result = false });
            betRecord.Add(new Bet { BetID = 5, RaceCourseName = "Fairyhouse", HorseName = "Quicksilver", Date = DateTime.Parse("02/12/2016"), Amount = 65.75m, Result = true });
            betRecord.Add(new Bet { BetID = 6, RaceCourseName = "Ayr", HorseName = "Lightning", Date = DateTime.Parse("11/03/2017"), Amount = 12.05m, Result = true });
            betRecord.Add(new Bet { BetID = 7, RaceCourseName = "Doncaster", HorseName = "QuickFeet", Date = DateTime.Parse("02/12/2017"), Amount = 10.00m, Result = false });
            betRecord.Add(new Bet { BetID = 8, RaceCourseName = "Towcester", HorseName = "Speedee", Date = DateTime.Parse("12/03/2016"), Amount = 50.00m, Result = false });
            betRecord.Add(new Bet { BetID = 9, RaceCourseName = "Goodwood", HorseName = "Zeus", Date = DateTime.Parse("07/10/2017"), Amount = 525.74m, Result = true });
            betRecord.Add(new Bet { BetID = 10, RaceCourseName = "Kelso", HorseName = "President", Date = DateTime.Parse("13/09/2016"), Amount = 43.21m, Result = true });
            betRecord.Add(new Bet { BetID = 11, RaceCourseName = "Punchestown", HorseName = "Sheriff", Date = DateTime.Parse("05/07/2017"), Amount = 35.00m, Result = false });
            betRecord.Add(new Bet { BetID = 12, RaceCourseName = "Ascot", HorseName = "Deputy", Date = DateTime.Parse("04/02/2016"), Amount = 23.65m, Result = true });
            betRecord.Add(new Bet { BetID = 13, RaceCourseName = "Kelso", HorseName = "Lucky", Date = DateTime.Parse("02/08/2017"), Amount = 30.00m, Result = false });
            betRecord.Add(new Bet { BetID = 14, RaceCourseName = "Towcester", HorseName = "Pablo", Date = DateTime.Parse("01/05/2017"), Amount = 104.33m, Result = true });
            betRecord.Add(new Bet { BetID = 14, RaceCourseName = "Ascot", HorseName = "Horseshoe", Date = DateTime.Parse("21/06/2017"), Amount = 25.00m, Result = false });
            betRecord.Add(new Bet { BetID = 15, RaceCourseName = "Bangor", HorseName = "Barley", Date = DateTime.Parse("22/12/2016"), Amount = 30.00m, Result = false });
            betRecord.Add(new Bet { BetID = 16, RaceCourseName = "Ayr", HorseName = "Bronco", Date = DateTime.Parse("22/05/2017"), Amount = 11.50m, Result = true });
            betRecord.Add(new Bet { BetID = 17, RaceCourseName = "Ascot", HorseName = "Blazer", Date = DateTime.Parse("23/06/2017"), Amount = 30.00m, Result = false });
            betRecord.Add(new Bet { BetID = 18, RaceCourseName = "Ascot", HorseName = "Wilbur", Date = DateTime.Parse("23/06/2017"), Amount = 374.27m, Result = true });
            betRecord.Add(new Bet { BetID = 19, RaceCourseName = "Goodwood", HorseName = "Buck", Date = DateTime.Parse("05/10/2016"), Amount = 34.12m, Result = true });
            betRecord.Add(new Bet { BetID = 20, RaceCourseName = "Dundalk", HorseName = "Franklin", Date = DateTime.Parse("09/11/2016"), Amount = 20.00m, Result = false });
            betRecord.Add(new Bet { BetID = 21, RaceCourseName = "Haydock", HorseName = "Kentucky", Date = DateTime.Parse("12/11/2016"), Amount = 87.00m, Result = true });
            betRecord.Add(new Bet { BetID = 22, RaceCourseName = "Perth", HorseName = "Trigger", Date = DateTime.Parse("20/01/2017"), Amount = 15.00m, Result = false });
            betRecord.Add(new Bet { BetID = 23, RaceCourseName = "York", HorseName = "Blacksmith", Date = DateTime.Parse("11/11/2017"), Amount = 101.25m, Result = true });
            betRecord.Add(new Bet { BetID = 24, RaceCourseName = "Punchestown", HorseName = "Buckeye", Date = DateTime.Parse("22/12/2016"), Amount = 11.50m, Result = true });
            betRecord.Add(new Bet { BetID = 25, RaceCourseName = "Chester", HorseName = "Queen", Date = DateTime.Parse("14/08/2016"), Amount = 10.00m, Result = false });
            betRecord.Add(new Bet { BetID = 26, RaceCourseName = "Kelso", HorseName = "Washington", Date = DateTime.Parse("18/09/2016"), Amount = 10.00m, Result = false });
            betRecord.Add(new Bet { BetID = 27, RaceCourseName = "Kilbeggan", HorseName = "Connecticut", Date = DateTime.Parse("03/03/2017"), Amount = 20.00m, Result = false });
            betRecord.Add(new Bet { BetID = 28, RaceCourseName = "Fairyhouse", HorseName = "Obama", Date = DateTime.Parse("11/03/2017"), Amount = 55.50m, Result = true });
            betRecord.Add(new Bet { BetID = 29, RaceCourseName = "Punchestown", HorseName = "King", Date = DateTime.Parse("15/11/2016"), Amount = 10.00m, Result = false });
            betRecord.Add(new Bet { BetID = 30, RaceCourseName = "Towcester", HorseName = "Jockey", Date = DateTime.Parse("08/05/2016"), Amount = 16.55m, Result = true });
            betRecord.Add(new Bet { BetID = 31, RaceCourseName = "Punchestown", HorseName = "Clydesdale", Date = DateTime.Parse("23/05/2016"), Amount = 13.71m, Result = true });
            betRecord.Add(new Bet { BetID = 32, RaceCourseName = "Cork", HorseName = "Wrangler", Date = DateTime.Parse("30/11/2016"), Amount = 20.00m, Result = false });
            betRecord.Add(new Bet { BetID = 33, RaceCourseName = "Punchestown", HorseName = "Jupiter", Date = DateTime.Parse("25/04/2016"), Amount = 13.45m, Result = true });
            betRecord.Add(new Bet { BetID = 34, RaceCourseName = "Bangor", HorseName = "Tennessee", Date = DateTime.Parse("23/01/2016"), Amount = 10.00m, Result = false });

            return betRecord;

        }
    } 
    
}
