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
        public int Id { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}