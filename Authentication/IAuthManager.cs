using System;
using System.Collections.Generic;
using System.Text;

namespace Authentication
{
    internal interface IAuthManager
    {
        public bool UserExists(string user);
        public void AddUser(string user, string pass);
    }
}
