using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HotTipster.BusinessLogic
{
    public class ExtensionMethods
    {
        public void WriteTofile()
        //loads the hard-coded data from myRecords class into the txt file using foreach loop with binary writer
        {
            List<Bet> bets = BetRecords.LoadBetRecords();
            foreach (var bet in bets)
            {
                using (var fileStream = new FileStream(@"C:\Users\Sonol\Documents\HotTipster.txt", FileMode.Append, FileAccess.Write, FileShare.None))
                using (var binaryWriter = new BinaryWriter(fileStream))
                {
                    Bet bet = new Bet(bet.RaceCourseName, bet.Date, bet.Amount, bet.Status);
                    binaryWriter.Write(Environment.NewLine + b.RaceCourse);
                    binaryWriter.Write(b.Date.ToString());
                    binaryWriter.Write(b.Amount.ToString());
                    binaryWriter.Write(b.Status);
                }
            }

        }

        public string Success(string result)
        //shows the efficiency of the HotTipster by calling GetAllData method and using Linq
        {
            List<Bet> bets = GetAllData();
            int races = 0;
            int successfulRaces = 0;

            races = bets.Count();
            successfulRaces = bets.Where(x => x.Status == "true").Count();

            result = successfulRaces + " won out of " + races;
            return result;
        }


        public string MostPopularRaceCourse(string result)
        //Returns the most popular race course by calling GetAllData method and using Linq
        {
            List<Bet> bets = GetAllData();
            var rcourse = bets.GroupBy(x => x.RaceCourse).OrderByDescending(g => g.Count()).Select(g => g.Key).First();

            string racecourse = rcourse.ToString();

            result = "The most popular race course is: " + racecourse;
            return result;
        }

        public string HighestWonMostLost(string result)
        //Returns the total won and lost amount in 2016 and 2017 by calling GetAllData method and using Linq
        {
            List<Bet> bets = GetAllData();
            decimal highestWon = 0;
            decimal mostLost = 0;
            highestWon = bets.Where(x => x.Status == "true").Max(x => x.Amount);
            mostLost = bets.Where(x => x.Status == "false").Max(x => x.Amount);
            result = "The highest amount won is: €" + highestWon + " and the most lost is: €" + mostLost;
            return result;
        }

        public string ShowTotalsByYear(string result)
        //Returns the highest amount won and most lost for a bet laid by calling GetAllData method and using Linq
        {
            List<Bet> bets = GetAllData();
            decimal totalProfit2016 = 0;
            decimal totalProfit2017 = 0;
            decimal totalLoss2016 = 0;
            decimal totalLoss2017 = 0;

            totalProfit2016 = bets.Where(x => x.Date.Year == 2016 && x.Status == "true").Sum(x => x.Amount);
            totalProfit2017 = bets.Where(x => x.Date.Year == 2017 && x.Status == "true").Sum(x => x.Amount);
            totalLoss2016 = bets.Where(x => x.Date.Year == 2016 && x.Status == "false").Sum(x => x.Amount);
            totalLoss2017 = bets.Where(x => x.Date.Year == 2017 && x.Status == "false").Sum(x => x.Amount);

            result = "Year" + "\tTotal Won" + "\tTotal Lost" + Environment.NewLine
                + "2016" + "\t€" + totalProfit2016 + "\t\t€" + totalLoss2016 + Environment.NewLine
                + "2017" + "\t€" + totalProfit2017 + "\t\t€" + totalLoss2017;
            return result;
        }

        public string ShowByDate(string result)
        //Displays all records ordering by date by calling GetAllData method and using Linq
        {
            List<Bet> bets = GetAllData();
            bets = bets.OrderBy(x => x.Date).ToList();
            foreach (var bet in bets)
            {
                result += ($"{bet.RaceCourse} {bet.Date} {bet.Amount} {bet.Status} ") + Environment.NewLine;
            }
            return result;
        }

        public void AppendData(string RaceCourse, DateTime Date, decimal Amount, string Status)
        //Insert data into txt file from user input
        {
            using (var fileStream = new FileStream(@"C:\Users\Kancsi\Documents\HotTipster.txt", FileMode.Append, FileAccess.Write, FileShare.None))
            using (var bw = new BinaryWriter(fileStream))
            {
                Bet b = new Bet(RaceCourse, Date, Amount, Status);
                bw.Write(Environment.NewLine + b.RaceCourse);
                bw.Write(b.Date.ToString());
                bw.Write(b.Amount.ToString());
                bw.Write(b.Status);
            }
        }

        public string ShowAllRecords(string result)
        //Displays all data from txt file 
        {
            using (Stream fStream = File.Open(@"C:\Users\Kancsi\Documents\HotTipster.txt", FileMode.Open))
            {

                using (BinaryReader reader = new BinaryReader(fStream))
                {
                    int length = (int)reader.BaseStream.Length;
                    while (reader.BaseStream.Position != length)
                    {
                        string RaceCourse = reader.ReadString();
                        DateTime Date = Convert.ToDateTime(reader.ReadString());
                        decimal Amount = Convert.ToDecimal(reader.ReadString());
                        string Status = reader.ReadString();
                        result += ($"{RaceCourse} {Date} {Amount} {Status} ") + Environment.NewLine;
                    }
                    return result;
                }
            }
        }

        public List<Bet> GetAllData()
        //Reads all line of data from the txt file into a list
        {
            Bet bet = new Bet();
            List<Bet> bets = new List<Bet>();
            using (Stream fStream = File.Open(@"C:\Users\Kancsi\Documents\HotTipster.txt", FileMode.Open))
            {
                using (BinaryReader reader = new BinaryReader(fStream))
                {


                    int length = (int)reader.BaseStream.Length;
                    while (reader.BaseStream.Position != length)
                    {
                        string RaceCourse = reader.ReadString();
                        DateTime Date = Convert.ToDateTime(reader.ReadString());
                        decimal Amount = Convert.ToDecimal(reader.ReadString());
                        string Status = reader.ReadString();
                        bets.Add(new Bet { RaceCourse = RaceCourse, Date = Date, Amount = Amount, Status = Status });
                    }
                }
            }
            return bets;
        }
    }
}
}
