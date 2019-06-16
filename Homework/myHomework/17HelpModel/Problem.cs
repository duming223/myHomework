using myHomework._17HelpModel;
using System;

namespace myHomework
{
    /// <summary>
    /// 求助
    /// </summary>
    public class Problem : CommonModel
    {
        private readonly string _problemTitle;
        private bool _isRemote;
        public string ProblemTitle { get; set; }
        public bool IsRemote { get; set; }
        public decimal Reward { get; set; }
        public Problem(string problemTitle, string problemBody, User seeker, bool isRemote)
        {
            this.Body = problemBody;
            this.User = seeker;
            this._problemTitle = problemTitle;
            this._isRemote = isRemote;
        }
        public void Publish()
        {
            Console.WriteLine($"{User.NickName}\t发布了一条求助《{_problemTitle}》,该求助需要远程：{_isRemote}");
        }
    }
}