using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace HotTipster.BusinessLogic
{
    public class HotTipsterMethods
    {
        //private List<HorseBet> _horseBets;

        //public void initalizeObject()
        //{
        //    _horseBets = GetAllBetRecordData();
        //}
        
        #region FileInputAndOutput
        
        public void WriteToTextFile() //Test method
        {
            var horseBets = BetRecords.LoadRoads();
            foreach (var horseBet in horseBets)
            {
                using (var fileStream = new FileStream(@"C:\Users\sonol\Downloads\_pcloud\_repositories\github\hottipster-dbs-project\HotTipster\HotTipsterReport.txt",
                    FileMode.Append, FileAccess.Write, FileShare.None))
                using (var binaryWriter = new BinaryWriter(fileStream))
                {
                    var bet = new HorseBet(horseBet.BetID, horseBet.RacecourseName,
                    horseBet.HorseName, horseBet.Date, horseBet.Amount, horseBet.Result);
                    binaryWriter.Write(Environment.NewLine + horseBet.BetID);//.ToString());
                    binaryWriter.Write(bet.RacecourseName);
                    binaryWriter.Write(bet.HorseName);
                    binaryWriter.Write(bet.Date.ToString());
                    binaryWriter.Write(bet.Amount.ToString());
                    binaryWriter.Write(bet.Result.ToString());
                }
            }
        }

        public void AppendData(int betID, string racecourseName,
            string horseName, DateTime date, //Test method
            decimal amount, bool result)
        {
            using (var fileStream = File.Open(
                @"C:\Users\sonol\Downloads\_pcloud\_repositories\github\hottipster-dbs-project\HotTipster\HotTipsterReport.txt",
                FileMode.Open))
            {
                using (var binaryWriter = new BinaryWriter(fileStream))
                {
                    var bet = new HorseBet(betID, racecourseName, horseName, date, amount, result);
                    binaryWriter.Write(Environment.NewLine + bet.BetID);//.ToString());
                    binaryWriter.Write(bet.RacecourseName);
                    binaryWriter.Write(bet.HorseName);
                    binaryWriter.Write(bet.Date.ToString());
                    binaryWriter.Write(bet.Amount.ToString());
                    binaryWriter.Write(bet.Result.ToString());
                }
            }
        }

        #endregion

        #region GeneralViewAll 
        
        //checkout
        public List<HorseBet> GetAllBetRecordData()
        {
           var horseBet = new HorseBet();
           var horseBets = new List<HorseBet>();

            using (Stream fileStream =
                File.Open(
                    @"C:\Users\sonol\Downloads\_pcloud\_repositories\github\hottipster-dbs-project\HotTipster\HotTipsterReport.txt",
                    FileMode.Open))
            {
                using (var binaryReader = new BinaryReader(fileStream))
                {
                    var length = (int)binaryReader.BaseStream.Length;
                    do
                    {
                        var betID = int.Parse(binaryReader.ReadString());
                        var racecourseName = binaryReader.ReadString();
                        var horseName = binaryReader.ReadString();
                        var date = DateTime.Parse(binaryReader.ReadString());
                        var amount = decimal.Parse(binaryReader.ReadString());
                        var result = bool.Parse(binaryReader.ReadString());
                        horseBets.Add(new HorseBet
                        {
                            BetID = betID,
                            RacecourseName = racecourseName,
                            HorseName = horseName,
                            Date = date,
                            Amount = amount,
                            Result = result
                        });
                    } while (binaryReader.BaseStream.Position != length);
                }
            }

            return horseBets;
        }

        public string ShowAllBetRecords(string horseBetRecord)
        {
            using (var fileStream = File.Open(
                @"C:\Users\sonol\Downloads\_pcloud\_repositories\github\advanced-horse-race-tipster\HotTipster\HotTipsterReport.txt",
                FileMode.Open))
            {
                using (var binaryReader = new BinaryReader(fileStream))
                {
                    var length = (int)binaryReader.BaseStream.Length;
                    do
                    {
                        var betID = int.Parse(binaryReader.ReadString());
                        var racecourseName = binaryReader.ReadString();
                        var horseName = binaryReader.ReadString();
                        var date = DateTime.Parse(binaryReader.ReadString());
                        var amount = decimal.Parse(binaryReader.ReadString());
                        var result = bool.Parse(binaryReader.ReadString());
                        horseBetRecord += ($"Bet ID: {betID}" +
                                           $"\nRaceCourse Name: {racecourseName}" +
                                           $"\nHorse Name: {horseName}" +
                                           $"\nDate: {date}" +
                                           $"\nAmount: {amount}" +
                                           $"\nWin or Lost: {result}") 
                                           + Environment.NewLine;
                    } while (binaryReader.BaseStream.Position != length);

                    return horseBetRecord;
                }
            }
        }

        #endregion

        #region FiltersByBetID
        
        public string GetHorseBetID(int betID)
        {
            string horseBetRecord;
            var horseBets = GetAllBetRecordData();
            foreach (var horseBet in horseBets)
            {
                if (horseBet.BetID.Equals(betID))
                {
                    return horseBetRecord = $"Bet ID: {horseBet.BetID}" +
                                            $"\nRaceCourse Name: {horseBet.RacecourseName}" +
                                            $"\nHorse Name: {horseBet.HorseName}" +
                                            $"\nDate: {horseBet.Date}" +
                                            $"\nAmount: {horseBet.Amount}" +
                                            $"\nWin or Lost: {horseBet.Result}";
                }
            }

            return horseBetRecord = $"Horse Bet ID {betID} not found";
        }
        #endregion

        //Used all function in form
        #region FilterByRacecourseName

        public string GetMostPopularRacecourseBets(string hourseBetRecord)
        {
            var horseBets = GetAllBetRecordData();
            var racecourseName = horseBets.GroupBy(racecourse => racecourse.RacecourseName)
                .OrderByDescending(popularRacecourse => popularRacecourse.Count())
                .Select(popularRacecourse => popularRacecourse.Key).First();

            var popularRacecourseName = racecourseName.ToString();

            hourseBetRecord = $"Most Popular racecourse for bets: {popularRacecourseName}";
            return hourseBetRecord;
        }
        #endregion

        //Used all function in form
        #region FilterByHorseName

        public string GetMostPopularHorse(string hourseBetRecord)
        {
            var horseBets = GetAllBetRecordData();
            var hourseName = horseBets.GroupBy(horse => horse.HorseName)
                .OrderByDescending(popularHorse => popularHorse.Count())
                .Select(popularHorse => popularHorse.Key).First();

            var popularHourseName = hourseName.ToString();

            hourseBetRecord = $"Most Popular hourse for bets: {popularHourseName}";
            return hourseBetRecord;
        }

        #endregion

        //Used all function in form
        #region FilterByDate

        //Not used in form
        public string ShowBetsByDate(string horseBetRecord)
        {
            var horseBets = GetAllBetRecordData();
            horseBets = horseBets.OrderBy(date => date.Date).ToList();
            foreach (var horseBet in horseBets)
            {
                horseBetRecord += ($"Bet ID: {horseBet.BetID}\nRaceCourse Name: {horseBet.RacecourseName}" +
                                   $"\nHorse Name: {horseBet.HorseName}\nDate: {horseBet.Date}" +
                                   $"\nAmount: {horseBet.Amount}\nWin or Lost: {horseBet.Result}")
                                   + Environment.NewLine;
            }

            return horseBetRecord;
        }
        
        public string ShowTotalWonAndLostBetsByYear(string hourseBetRecord)
        {
            var horseBets = GetAllBetRecordData();
            decimal totalWon2016 = 0;
            decimal totalWon2017 = 0;
            decimal totalLost2016 = 0;
            decimal totalLost2017 = 0;

            totalWon2016 = horseBets.Where(money => money.Date.Year == 2016 && money.Result == true)
                .Sum(money => money.Amount);
            totalLost2016 = horseBets.Where(money => money.Date.Year == 2016 && money.Result == false)
                .Sum(money => money.Amount);
            totalWon2017 = horseBets.Where(money => money.Date.Year == 2017 && money.Result == true)
                .Sum(money => money.Amount);
            totalLost2017 = horseBets.Where(money => money.Date.Year == 2017 && money.Result == false)
                .Sum(money => money.Amount);

            hourseBetRecord =   $"Year\tTotal Won\tTotal Lost " + Environment.NewLine 
                              + $"2016\t€{totalWon2016}\t{totalLost2016}" + Environment.NewLine
                              + $"2017\t€{totalWon2017}\t{totalLost2017}" + Environment.NewLine;

            return hourseBetRecord;
        }

        #endregion

        //Used all function in form
        #region FilterByAmount
        //Get highest amount won for a bet laid and the most lost for a bet laid.
        //Not used in form yet
        public string GetHighestAmountWon(string horseBetRecord)
        {
            var horseBets = GetAllBetRecordData();
            decimal highestBetWon = 0;

            highestBetWon = horseBets.Where(bet => bet.Result == true).Max(bet => bet.Amount);
            horseBetRecord = $"The hightest amount won for a bet laid: €{highestBetWon}";

            return horseBetRecord;
        }

        public string GetMostAmountLost(string horseBetRecord)
        {
            var horseBets = GetAllBetRecordData();
            decimal highestBetLost = 0;

            highestBetLost = horseBets.Where(bet => bet.Result == false).Max(bet => bet.Amount);
            horseBetRecord = $"The hightest amount lost for a bet laid: €{highestBetLost}";

            return horseBetRecord;
        }

        public string GetHighestAmountWonAndLost(string horseBetRecord)
        {
            var horseBets = GetAllBetRecordData();
            decimal highestBetWon = 0;
            decimal highestBetLost = 0;

            highestBetWon = horseBets.Where(bet => bet.Result == true).Max(bet => bet.Amount);
            highestBetLost = horseBets.Where(bet => bet.Result == false).Max(bet => bet.Amount);
            horseBetRecord = $"The highest amount won: €{highestBetWon}" +
                             $"\nThe highest amount lost: €{highestBetLost}";

            return horseBetRecord;
        }

        #endregion

        //Used all function in form
        #region FilterByResult

        //total number of races alongside the number of races that HotTipster has won a bet on
        public string GetTotalNumberOfRacesAndWins(string horseRecord)
        {
            var horseBets = GetAllBetRecordData();
            var horseRace = 0;
            var sucessfulhorseRace = 0;

            horseRace = horseBets.Count();
            sucessfulhorseRace = horseBets.Where(race => race.Result == true).Count();
            //sucessfulhorseRace = horseBets.Count(race => race.Result == true);

            horseRecord = $"Total number of races and HotTipster wins: {sucessfulhorseRace}/{horseRace}";
            return horseRecord;
        }

        #endregion
    }
}
