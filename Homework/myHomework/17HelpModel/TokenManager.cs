using System;
using System.Collections.Generic;
using System.Text;

namespace myHomework._17HelpModel
{
    public class TokenManager
    {
        private IList<string> _tokens;
        public TokenManager()
        {
            _tokens = Get();
        }

        public static IList<string> Get()
        {
            IList<string> enums = new List<string>();
            foreach (var s in Enum.GetNames(typeof(Token)))
            {
                enums.Add(s);
            }
            return enums;
        }
        public void Add(Token token)
        {
            _tokens.Add(token.ToString());
        }
        public void Remove(Token token)
        {
            _tokens.Remove(token.ToString());
        }
        public void Has(Token token)
        {
            _tokens.Contains(token.ToString());
        }
    }
}
