using System;
using System.Collections.Generic;
using System.Text;

namespace myHomework._17HelpModel
{
    public class TokenManager
    {
        public static void Call()
        {
            User user = new User("xiao");
            Map(user);
            user.Tokens.Add(Token.Admin);
            user.Tokens.Add(Token.Blogger);
            user.Tokens.Remove(Token.Blogger);
            Console.WriteLine(user.Tokens.Has(Token.Newbie));
            Console.WriteLine(user.Tokens.Get());
        }

        //反射获取实例
        private static void Map(User user)
        {
            object obj = Activator.CreateInstance(typeof(TokenManager));
            user.Tokens = (TokenManager)obj;
        }

        private Token _tokens;
        public Token Get()
        {
            return _tokens;
        }
        public void Add(Token token)
        {
            _tokens = (_tokens | token);
        }
        public void Remove(Token token)
        {
            //&用于空权限remove情况
            _tokens = _tokens & (_tokens ^ token);
        }
        public bool Has(Token token)
        {
            //true 包含权限.token可以隐式转换为对应数字
            //return _tokens.HasFlag(token);
            return (_tokens & token) > 0;
        }
    }
}
