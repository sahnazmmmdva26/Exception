namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MeetingSchedule meetingSchedule = new MeetingSchedule();
            Meeting meeting = new Meeting(new DateTime(2020, 7, 12), new DateTime(2020, 7, 15), "ygydgy");
            meetingSchedule.SetMeeting(new DateTime(2020, 8, 12),new DateTime(2020,8,15), "Shahnaz");
            meetingSchedule.SetMeeting(new DateTime(2020, 8, 13), new DateTime(2020, 8, 17), "Shahnaz");
            
        }
    }
}