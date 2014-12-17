using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniCodedUITest.Libraries
{
    public class InvalidLoginException : Exception
    {
        public InvalidLoginException() : base() { }
        public InvalidLoginException(string msg) : base(msg) { }
        public InvalidLoginException(string msg, Exception e) : base(msg, e) { }

        private string loggedInUsername;
        public string LoggedInUsername
        {
            get { return loggedInUsername; }
            set { loggedInUsername = value; }
        }

        private string loggedInPassword;
        public string LoggedInPassword
        {
            get { return loggedInPassword; }
            set { loggedInPassword = value; }
        }
    }
}
