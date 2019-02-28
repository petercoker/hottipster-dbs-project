using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace HotTipster.BusinessLogic
{
    public class HotTipsterMethods
    {
        public static string directoryPath =
            @"C:\Users\sonol\Downloads\_pcloud\_repositories\github\hottipster-dbs-project\HotTipster\";

        public static string directoryPathBin =
            @"C:\Users\sonol\Downloads\_pcloud\_repositories\github\hottipster-dbs-project\HotTipster\HotTipster\BusinessLogic";

        public static string fileName_HorseBet = "HorseBet.bin";
        public static string fileName_HotTipsHistoricData = "HotTipsHistoricData.txt";
        public static string fileName_HotTipsterReport = "HotTipsterReport.txt";
        private string[] stringSplitCommaSeparator = { "," };
        #region FileInputAndOutput

        //public List<HorseBet> ListOfHotTipsHistoricData2()
        //{
        //    var result = new List<HorseBet>();
        //    try
        //    {
        //        using (FileStream fs = File.OpenRead($@"{directoryPath}{fileName_HotTipsHistoricData}"))
        //        using (TextReader myreader = new StreamReader(fs, Encoding.UTF8))
        //        {
        //            while (myreader.Peek() > -1)
        //            {
        //                string line = myreader.ReadLine();
        //                string[] bet = line.Split(stringSplitCommaSeparator, StringSplitOptions.RemoveEmptyEntries);
        //                bet = TrimArrayStrings(bet);
        //                bet[1] = bet[1].Substring(1, 4);
        //                bet[3] = bet[3].Substring(0, 2);
        //                bet[4] = bet[4].Substring(0, bet[4].Length - 1);

        //                result.Add(new HorseBet(bet[0], new DateTime(int.Parse(bet[1]), int.Parse(bet[2]), int.Parse(bet[3])), decimal.Parse(bet[4]), bool.Parse(bet[5]), 0));
        //            }
        //        }
        //    }
        //    catch
        //    {

        //        throw new Exception("File input does not match expected datatypes");
        //    }

        //    return result;
        //}

        //public static List<HorseBet> ListOfHotTipsHistoricData()
        //{
        //    var bet = new HorseBet();

        //    List<HorseBet> betRecord = new List<HorseBet>();

        //    using (var fileStreams = new FileStream($@"{directoryPath}{fileName_HotTipsHistoricData}", FileMode.Open))
        //    using (var binaryReader = new BinaryReader(fileStreams))
        //    {
        //        while (binaryReader.PeekChar() != -1)
        //        {
        //            var raceCourse = binaryReader.ReadString();
        //            var raceDate = binaryReader.ReadString();
        //            var date = DateTime.Parse(raceDate);
        //            //var date = DateTime.Parse(binaryReader.ReadString());
        //            var amount = binaryReader.ReadDecimal();
        //            var result = binaryReader.ReadBoolean();
        //            betRecord.Add(new HorseBet() { RaceCourse = raceCourse, Date = date, Amount = amount, Result = result });
        //        }

        //    }
        //    return betRecord;
        //}

        //public static List<HorseBet> LoadHotTipsHistoricData()
        //{

        //    //var result = new List<HorseBet>();
        //    //try
        //    //{
        //    //    using (FileStream fs = File.OpenRead($@"{directoryPath}{fileName_HotTipsHistoricData}"))
        //    //    using (TextReader myreader = new StreamReader(fs, Encoding.UTF8))
        //    //    {
        //    //        while (myreader.Peek() > -1)
        //    //        {
        //    //            string line = myreader.ReadLine();
        //    //            string[] bet = line.Split(stringSplitCommaSeparator, StringSplitOptions.RemoveEmptyEntries);
        //    //            bet = MyUtilities.TrimArrayStrings(bet);
        //    //            bet[1] = bet[1].Substring(1, 4);
        //    //            bet[3] = bet[3].Substring(0, 2);
        //    //            bet[4] = bet[4].Substring(0, bet[4].Length - 1);

        //    //            result.Add(new HorseBet(bet[0], new DateTime(int.Parse(bet[1]), int.Parse(bet[2]), int.Parse(bet[3])), decimal.Parse(bet[4]), bool.Parse(bet[5]), 0));
        //    //        }
        //    //    }
        //    //}
        //    //catch
        //    //{

        //    //    throw new Exception("File input does not match expected datatypes");
        //    //}

        //    //return result;
        //    //var bet = new HorseBet();

        //    List<HorseBet> betRecord = new List<HorseBet>();

        //    using (var fileStreams = new FileStream($@"{directoryPath}{fileName_HotTipsterReport}", FileMode.Open))
        //    using (var binaryReader = new BinaryReader(fileStreams))
        //    {
        //        while (binaryReader.PeekChar() != -1)
        //        {
        //            var raceCourse = binaryReader.ReadString();
        //            var raceDate = binaryReader.ReadString();
        //            var date = DateTime.Parse(raceDate);
        //            //var date = DateTime.Parse(binaryReader.ReadString());
        //            var amount = binaryReader.ReadDecimal();
        //            var result = binaryReader.ReadBoolean();
        //            betRecord.Add(new HorseBet() { RaceCourse = raceCourse, Date = date, Amount = amount, Result = result });
        //        }

        //    }
        //    return betRecord;
        //}


        //public void WriteToTextFile() //Test method
        //{
        //    //var horseBets = BetRecords.LoadRoads();
        //    var horseBets = ListOfHotTipsHistoricData();
        //    foreach (var horseBet in horseBets)
        //    {
        //        using (var fileStream = new FileStream($@"{directoryPath}{fileName_HotTipsterReport}",
        //            FileMode.Append, FileAccess.Write, FileShare.None))
        //        using (var binaryWriter = new BinaryWriter(fileStream))
        //        {
        //            var bet = new HorseBet(horseBet.RaceCourse, horseBet.Date, horseBet.Amount, horseBet.Result);
        //            binaryWriter.Write(Environment.NewLine + bet.RaceCourse);
        //            binaryWriter.Write(bet.Date.ToString());
        //            binaryWriter.Write(bet.Amount.ToString());
        //            binaryWriter.Write(bet.Result.ToString());
        //        }
        //    }
        //}

        public void AppendData(string raceCourse, string date, 
            decimal amount, bool result) //Tested 
        {
            using (var fileStream = File.Open(
                $@"{directoryPath}{fileName_HotTipsterReport}", FileMode.Append))
            {
                using (var textWriter = new StreamWriter(fileStream))
                {
                    var bet = new HorseBet(raceCourse, date, amount, result);
                    textWriter.Write($"{bet.RaceCourse}, {bet.Date}, {bet.Amount}, {bet.Result} {Environment.NewLine}");
                }

                //using (var binaryWriter = new BinaryWriter(fileStream))
                //{
                //    var bet = new HorseBet(raceCourse, date, amount, result);
                //    binaryWriter.Write(Environment.NewLine + bet.RaceCourse); ;
                //    binaryWriter.Write(bet.Date);
                //    binaryWriter.Write(bet.Amount.ToString());
                //    binaryWriter.Write(bet.Result.ToString());
                //}
            }
        }

        #endregion

        #region GeneralViewAll 

        //public DateTime TrimDateTime(DateTime raceDate)
        //{

        //}


        //checkout
        public List<HorseBet> GetAllBetRecordData()
        {
            using (Stream fileStreams = new FileStream($@"{directoryPathBin}{fileName_HotTipsHistoricData}", FileMode.Open))
            using (var binaryReader = new BinaryReader(fileStreams))
            {
                List<HorseBet> betRecord = new List<HorseBet>();
                while (binaryReader.PeekChar() != -1)
                {
                    var raceCourse = binaryReader.ReadString();
                    var date = binaryReader.ReadString();
                    var amount = binaryReader.ReadDecimal();
                    var result = binaryReader.ReadBoolean();
                    //betRecord.Add(new HorseBet() {RaceCourse = raceCourse, Date = date, Amount = amount, Result = result});
                }

                return betRecord;
            }
            

            //using (Stream fileStream =
            //     File.Open($@"{directoryPath}{fileName_HotTipsHistoricData}", FileMode.Open))
            //{
            //    using (var binaryReader = new BinaryReader(fileStream))
            //    {
            //        List<HorseBet> horseBets = new List<HorseBet>();
            //        var length = (int)binaryReader.BaseStream.Length;
            //        do
            //        {
            //            var raceCourse = binaryReader.ReadString();
            //            var date = DateTime.ParseExact(binaryReader.ReadString(), "yyyy-MM-dd", CultureInfo.InvariantCulture);
            //            var amount = decimal.Parse(binaryReader.ReadString());
            //            var result = bool.Parse(binaryReader.ReadString());
            //            horseBets.Add(new HorseBet
            //            {
            //                RaceCourse = raceCourse,
            //                Date = date,
            //                Amount = amount,
            //                Result = result
            //            });
            //        } while (binaryReader.PeekChar() != -1);

            //        return horseBets;
            //    }
            //}
            //var horseBet = new HorseBet();
            //var horseBets = new List<HorseBet>();

            // using (Stream fileStream =
            //     File.Open($@"{directoryPath}{fileName_HotTipsterReport}", FileMode.Open))
            // {
            //     using (var binaryReader = new BinaryReader(fileStream))
            //     {
            //         var length = (int)binaryReader.BaseStream.Length;
            //         do
            //         {
            //             var raceCourse = binaryReader.ReadString();
            //             var date = DateTime.ParseExact(binaryReader.ReadString(), "yyyy-MM-dd", CultureInfo.InvariantCulture);
            //             var amount = decimal.Parse(binaryReader.ReadString());
            //             var result = bool.Parse(binaryReader.ReadString());
            //             horseBets.Add(new HorseBet
            //             {
            //                 RaceCourse = raceCourse,
            //                 Date = date,
            //                 Amount = amount,
            //                 Result = result
            //             });
            //         } while (binaryReader.BaseStream.Position != length);
            //     }
            // }

            //return horseBets;
        }
        

        public string ShowAllBetRecords(string horseBetRecord)
        {
            using (var fileStream = File.Open($@"{directoryPath}{fileName_HotTipsterReport}", FileMode.Open))
            {
                using (var binaryReader = new BinaryReader(fileStream))
                {
                    var length = (int)binaryReader.BaseStream.Length;
                    do
                    {
                        var raceCourse = binaryReader.ReadString();
                        var date = binaryReader.ReadString();
                        var amount = decimal.Parse(binaryReader.ReadString());
                        var result = bool.Parse(binaryReader.ReadString());
                        horseBetRecord +=$"{raceCourse}, {date}, {amount}m, {result}" + Environment.NewLine;
                    } while (binaryReader.BaseStream.Position != length);

                    return horseBetRecord;
                }
            }
        }

        #endregion
        
        //Used all function in form
        #region FilterByRaceCourse

        public string GetMostPopularRaceCourseBets(string hourseBetRecord)
        {
            var horseBets = GetAllBetRecordData();
            var racecourseName = horseBets.GroupBy(r => r.RaceCourse)
                .OrderByDescending(p => p.Count())
                .Select(p => p.Key).First();

            var popularRaceCourse = racecourseName.ToString();

            hourseBetRecord = $"Most Popular racecourse for bets: {popularRaceCourse}";
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
                horseBetRecord += ($"{horseBet.RaceCourse}, ({horseBet.Date}), {horseBet.Amount}, {horseBet.Result}") + Environment.NewLine;
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

            totalWon2016 = horseBets.Where(money => money.Date == "2016" && money.Result == true)
                .Sum(money => money.Amount);
            totalLost2016 = horseBets.Where(money => money.Date == "2016" && money.Result == false)
                .Sum(money => money.Amount);
            totalWon2017 = horseBets.Where(money => money.Date == "2017" && money.Result == true)
                .Sum(money => money.Amount);
            totalLost2017 = horseBets.Where(money => money.Date == "2017" && money.Result == false)
                .Sum(money => money.Amount);

            //totalWon2016 = horseBets.Where(money => money.Date.Year == 2016 && money.Result == true)
            //    .Sum(money => money.Amount);
            //totalLost2016 = horseBets.Where(money => money.Date.Year == 2016 && money.Result == false)
            //    .Sum(money => money.Amount);
            //totalWon2017 = horseBets.Where(money => money.Date.Year == 2017 && money.Result == true)
            //    .Sum(money => money.Amount);
            //totalLost2017 = horseBets.Where(money => money.Date.Year == 2017 && money.Result == false)
            //    .Sum(money => money.Amount);

            hourseBetRecord =   ($"Year\tTotal Won\tTotal Lost\n2016\t€{totalWon2016}\t{totalLost2016}\n2017\t€{totalWon2017}\t{totalLost2017}") + Environment.NewLine;

            return hourseBetRecord;
        }

        #endregion

        //Used all function in form
        #region FilterByAmount
        //Get highest amount won for a bet laid and the most lost for a bet laid.
        //Not used in form yet

        public string GetHighestAmountWonAndLost(string horseBetRecord)
        {
            var horseBets = GetAllBetRecordData();
            decimal highestBetWon = 0;
            decimal highestBetLost = 0;

            highestBetWon = horseBets.Where(b => b.Result == true).Max(b => b.Amount);
            highestBetLost = horseBets.Where(b => b.Result == false).Max(b => b.Amount);
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
            sucessfulhorseRace = horseBets.Where(r => r.Result == true).Count();
            //sucessfulhorseRace = horseBets.Count(r => r.Result == true);

            horseRecord = $"Total number of races and HotTipster wins: {sucessfulhorseRace}/{horseRace}";
            return horseRecord;
        }

        #endregion
        

    }
}
