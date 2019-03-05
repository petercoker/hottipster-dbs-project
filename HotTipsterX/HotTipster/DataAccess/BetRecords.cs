using System;
using System.Collections.Generic;

namespace HotTipster.DataAccess
{
    //public class BetRecords
    //{
    //    public static List<HorseBet> LoadRoads()
    //    {
    //        List<HorseBet> betRecord = new List<HorseBet>();

    //      // betRecord.Add(new HorseBet { RaceCourse = "Aintree", Date = "12/05/2017", Amount = 11.58m, Result = true });
    //      //betRecord.Add(new HorseBet { RaceCourse = "Punchestown", Date = "22/12/2016", Amount = 122.52m, Result = true });
    //      //betRecord.Add(new HorseBet { RaceCourse = "Sandown",  Date = "17/11/2016", Amount = 20.00m, Result = false });
    //      //betRecord.Add(new HorseBet { RaceCourse = "Ayr",  Date = "03/11/2016", Amount = 25.00m, Result = false });
    //      //betRecord.Add(new HorseBet { RaceCourse = "Fairyhouse",  Date = "02/12/2016", Amount = 65.75m, Result = true });
    //      //betRecord.Add(new HorseBet { RaceCourse = "Ayr",  Date = "11/03/2017"), Amount = 12.05m, Result = true });
    //      //betRecord.Add(new HorseBet { RaceCourse = "Doncaster",  Date = "02/12/2017"), Amount = 10.00m, Result = false });
    //      //betRecord.Add(new HorseBet { RaceCourse = "Towcester", Date = "12/03/2016"), Amount = 50.00m, Result = false });
    //      //betRecord.Add(new HorseBet { RaceCourse = "Goodwood", Date = "07/10/2017"), Amount = 525.74m, Result = true });
    //      //betRecord.Add(new HorseBet { RaceCourse = "Kelso", Date = "13/09/2016"), Amount = 43.21m, Result = true });
    //      //betRecord.Add(new HorseBet { RaceCourse = "Punchestown",  Date = "05/07/2017"), Amount = 35.00m, Result = false });
    //      //betRecord.Add(new HorseBet { RaceCourse = "Ascot",  Date = "04/02/2016"), Amount = 23.65m, Result = true });
    //      //betRecord.Add(new HorseBet { RaceCourse = "Kelso", Date = "02/08/2017"), Amount = 30.00m, Result = false });
    //      //betRecord.Add(new HorseBet { RaceCourse = "Towcester", Date = "01/05/2017"), Amount = 104.33m, Result = true });
    //      //betRecord.Add(new HorseBet { RaceCourse = "Ascot", Date = "21/06/2017"), Amount = 25.00m, Result = false });
    //      //betRecord.Add(new HorseBet { RaceCourse = "Bangor", Date = "22/12/2016"), Amount = 30.00m, Result = false });
    //      //betRecord.Add(new HorseBet { RaceCourse = "Ayr", Date = "22/05/2017"), Amount = 11.50m, Result = true });
    //      //betRecord.Add(new HorseBet { RaceCourse = "Ascot", Date = "23/06/2017"), Amount = 30.00m, Result = false });
    //      //betRecord.Add(new HorseBet { RaceCourse = "Ascot", Date = "23/06/2017"), Amount = 374.27m, Result = true });
    //      //betRecord.Add(new HorseBet { RaceCourse = "Goodwood", Date = "05/10/2016"), Amount = 34.12m, Result = true });
    //      //betRecord.Add(new HorseBet { RaceCourse = "Dundalk", Date = "09/11/2016"), Amount = 20.00m, Result = false });
    //      //betRecord.Add(new HorseBet { RaceCourse = "Haydock", Date = "12/11/2016"), Amount = 87.00m, Result = true });
    //      //betRecord.Add(new HorseBet { RaceCourse = "Perth",  Date = "20/01/2017"), Amount = 15.00m, Result = false });
    //      //betRecord.Add(new HorseBet { RaceCourse = "York", Date = "11/11/2017"), Amount = 101.25m, Result = true });
    //      //betRecord.Add(new HorseBet { RaceCourse = "Punchestown", Date = "22/12/2016"), Amount = 11.50m, Result = true });
    //      //betRecord.Add(new HorseBet { RaceCourse = "Chester",  Date = "14/08/2016"), Amount = 10.00m, Result = false });
    //      //betRecord.Add(new HorseBet { RaceCourse = "Kelso", Date = "18/09/2016"), Amount = 10.00m, Result = false });
    //      //betRecord.Add(new HorseBet { RaceCourse = "Kilbeggan", Date = "03/03/2017"), Amount = 20.00m, Result = false });
    //      //betRecord.Add(new HorseBet { RaceCourse = "Fairyhouse", Date = "11/03/2017"), Amount = 55.50m, Result = true });
    //      //betRecord.Add(new HorseBet { RaceCourse = "Punchestown", Date = "15/11/2016"), Amount = 10.00m, Result = false });
    //      //betRecord.Add(new HorseBet { RaceCourse = "Towcester", Date = "08/05/2016"), Amount = 16.55m, Result = true });
    //      //betRecord.Add(new HorseBet { RaceCourse = "Punchestown", Date = "23/05/2016"), Amount = 13.71m, Result = true });
    //      //betRecord.Add(new HorseBet { RaceCourse = "Cork", Date = "30/11/2016"), Amount = 20.00m, Result = false });
    //      //betRecord.Add(new HorseBet { RaceCourse = "Punchestown", Date = "25/04/2016"), Amount = 13.45m, Result = true });
    //      //betRecord.Add(new HorseBet { RaceCourse = "Bangor", Date = "23/01/2016"), Amount = 10.00m, Result = false });




    //        //betRecord.Add(new HorseBet { RaceCourse = "Aintree", Date = DateTime.Parse("12/05/2017"), Amount = 11.58m, Result = true });
    //        //betRecord.Add(new HorseBet { RaceCourse = "Punchestown", Date = DateTime.Parse("22/12/2016"), Amount = 122.52m, Result = true });
    //        //betRecord.Add(new HorseBet { RaceCourse = "Sandown",  Date = DateTime.Parse("17/11/2016"), Amount = 20.00m, Result = false });
    //        //betRecord.Add(new HorseBet { RaceCourse = "Ayr",  Date = DateTime.Parse("03/11/2016"), Amount = 25.00m, Result = false });
    //        //betRecord.Add(new HorseBet { RaceCourse = "Fairyhouse",  Date = DateTime.Parse("02/12/2016"), Amount = 65.75m, Result = true });
    //        //betRecord.Add(new HorseBet { RaceCourse = "Ayr",  Date = DateTime.Parse("11/03/2017"), Amount = 12.05m, Result = true });
    //        //betRecord.Add(new HorseBet { RaceCourse = "Doncaster",  Date = DateTime.Parse("02/12/2017"), Amount = 10.00m, Result = false });
    //        //betRecord.Add(new HorseBet { RaceCourse = "Towcester", Date = DateTime.Parse("12/03/2016"), Amount = 50.00m, Result = false });
    //        //betRecord.Add(new HorseBet { RaceCourse = "Goodwood", Date = DateTime.Parse("07/10/2017"), Amount = 525.74m, Result = true });
    //        //betRecord.Add(new HorseBet { RaceCourse = "Kelso", Date = DateTime.Parse("13/09/2016"), Amount = 43.21m, Result = true });
    //        //betRecord.Add(new HorseBet { RaceCourse = "Punchestown",  Date = DateTime.Parse("05/07/2017"), Amount = 35.00m, Result = false });
    //        //betRecord.Add(new HorseBet { RaceCourse = "Ascot",  Date = DateTime.Parse("04/02/2016"), Amount = 23.65m, Result = true });
    //        //betRecord.Add(new HorseBet { RaceCourse = "Kelso", Date = DateTime.Parse("02/08/2017"), Amount = 30.00m, Result = false });
    //        //betRecord.Add(new HorseBet { RaceCourse = "Towcester", Date = DateTime.Parse("01/05/2017"), Amount = 104.33m, Result = true });
    //        //betRecord.Add(new HorseBet { RaceCourse = "Ascot", Date = DateTime.Parse("21/06/2017"), Amount = 25.00m, Result = false });
    //        //betRecord.Add(new HorseBet { RaceCourse = "Bangor", Date = DateTime.Parse("22/12/2016"), Amount = 30.00m, Result = false });
    //        //betRecord.Add(new HorseBet { RaceCourse = "Ayr", Date = DateTime.Parse("22/05/2017"), Amount = 11.50m, Result = true });
    //        //betRecord.Add(new HorseBet { RaceCourse = "Ascot", Date = DateTime.Parse("23/06/2017"), Amount = 30.00m, Result = false });
    //        //betRecord.Add(new HorseBet { RaceCourse = "Ascot", Date = DateTime.Parse("23/06/2017"), Amount = 374.27m, Result = true });
    //        //betRecord.Add(new HorseBet { RaceCourse = "Goodwood", Date = DateTime.Parse("05/10/2016"), Amount = 34.12m, Result = true });
    //        //betRecord.Add(new HorseBet { RaceCourse = "Dundalk", Date = DateTime.Parse("09/11/2016"), Amount = 20.00m, Result = false });
    //        //betRecord.Add(new HorseBet { RaceCourse = "Haydock", Date = DateTime.Parse("12/11/2016"), Amount = 87.00m, Result = true });
    //        //betRecord.Add(new HorseBet { RaceCourse = "Perth",  Date = DateTime.Parse("20/01/2017"), Amount = 15.00m, Result = false });
    //        //betRecord.Add(new HorseBet { RaceCourse = "York", Date = DateTime.Parse("11/11/2017"), Amount = 101.25m, Result = true });
    //        //betRecord.Add(new HorseBet { RaceCourse = "Punchestown", Date = DateTime.Parse("22/12/2016"), Amount = 11.50m, Result = true });
    //        //betRecord.Add(new HorseBet { RaceCourse = "Chester",  Date = DateTime.Parse("14/08/2016"), Amount = 10.00m, Result = false });
    //        //betRecord.Add(new HorseBet { RaceCourse = "Kelso", Date = DateTime.Parse("18/09/2016"), Amount = 10.00m, Result = false });
    //        //betRecord.Add(new HorseBet { RaceCourse = "Kilbeggan", Date = DateTime.Parse("03/03/2017"), Amount = 20.00m, Result = false });
    //        //betRecord.Add(new HorseBet { RaceCourse = "Fairyhouse", Date = DateTime.Parse("11/03/2017"), Amount = 55.50m, Result = true });
    //        //betRecord.Add(new HorseBet { RaceCourse = "Punchestown", Date = DateTime.Parse("15/11/2016"), Amount = 10.00m, Result = false });
    //        //betRecord.Add(new HorseBet { RaceCourse = "Towcester", Date = DateTime.Parse("08/05/2016"), Amount = 16.55m, Result = true });
    //        //betRecord.Add(new HorseBet { RaceCourse = "Punchestown", Date = DateTime.Parse("23/05/2016"), Amount = 13.71m, Result = true });
    //        //betRecord.Add(new HorseBet { RaceCourse = "Cork", Date = DateTime.Parse("30/11/2016"), Amount = 20.00m, Result = false });
    //        //betRecord.Add(new HorseBet { RaceCourse = "Punchestown", Date = DateTime.Parse("25/04/2016"), Amount = 13.45m, Result = true });
    //        //betRecord.Add(new HorseBet { RaceCourse = "Bangor", Date = DateTime.Parse("23/01/2016"), Amount = 10.00m, Result = false });

    //        return betRecord;
    //    }
    //}
}
