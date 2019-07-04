using System;

namespace myHomework._17HelpModel
{
    public class DisAgree
    {
        public int Id { get; }
        public User User { get; set; }
        public int DisAgreeCount { get; set; }
        public DateTime Date { get; set; }
    }
}