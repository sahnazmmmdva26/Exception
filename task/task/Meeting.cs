using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class Meeting
    {
        DateTime _fromDate;
        DateTime _toDate;
        string _fullName;

        public DateTime FromDate
        {
            get { return _fromDate; }
            set { _fromDate = value; }
        }
        public DateTime ToDate
        {
            set { _toDate = value; }
            get { return _toDate; }
        }
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }

        public Meeting(DateTime fromDate, DateTime toDate, string fullName)
        {
            FromDate = fromDate;
            ToDate = toDate;
            FullName = fullName;
        }
    }
}
