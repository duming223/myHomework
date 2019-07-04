using System;

namespace myHomework._17HelpModel
{
    public class Agree
    {
        public int Id { get; }
        public int AgreeCount { get; set; }
        public User User { get; set; }
        public DateTime Date { get; set; }
    }
}