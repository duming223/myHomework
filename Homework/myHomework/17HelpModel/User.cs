namespace myHomework._17HelpModel
{
    /// <summary>
    /// 用户
    /// </summary>
    public class User
    {
        public User(string nickName)
        {
            NickName = nickName;
        }
        public int Id { get; }
        public string NickName { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }
        public TokenManager Tokens { get; set; }
    }
}