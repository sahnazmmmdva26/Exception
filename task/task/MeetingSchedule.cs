using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class MeetingSchedule
    {
        Meeting[] _meetings;

        public Meeting[] Meetings
        {
            get { return _meetings; }
            set
            {
                _meetings = value;
            }
        }
        public MeetingSchedule()
        {
            _meetings=new Meeting[0];
        }
        public void SetMeeting(DateTime fromDate, DateTime toDate, string fullName)
        {
            try
            {
                Meeting meeting = new Meeting(fromDate, toDate, fullName);
                for (int i = 0; i < _meetings.Length; i++)
                {
                    Meeting m = _meetings[i];
                    if (!(fromDate < m.FromDate && toDate < m.FromDate) || !(toDate > m.ToDate && fromDate > m.ToDate))
                    {
                        throw new ReservedDateInterval("rezerv olunmush tarix");
                    }
                    if(fromDate > toDate)
                    {
                        throw new WrongDateInterval("yanlis tarix intervali");
                    }

                }
                Array.Resize(ref _meetings, _meetings.Length + 1);
                _meetings[_meetings.Length - 1] = meeting;
            }
            catch (WrongDateInterval e)
            {
                Console.WriteLine(e.Message);
            }
            catch(ReservedDateInterval e)
            {
                Console.WriteLine(e.Message);
            }
           
           
        }
    }
}
