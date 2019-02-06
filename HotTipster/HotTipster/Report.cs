using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotTipster
{
    public class Report : IComparable<Report>
    {
        public int BetID { get; set; }
        public RaceCourseEnum RaceCourse { get; set; }
        public DateTime Date { get; set; }
        public decimal AmountWonOrLost { get; set; }
        public bool WinLost { get; set; }

        public Report()
        {
            BetID = 0;
        }
        
        int IComparable<Report>.CompareTo(Report other)
        {
            throw new NotImplementedException();
        }
    }
}
