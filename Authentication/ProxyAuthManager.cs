using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static Authentication.RealAuthManager;

namespace Authentication
{
    public class ProxyAuthManager : IAuthManager
    {
        private readonly RealAuthManager _realAuthManager;

        public ProxyAuthManager()
        {
            if(_realAuthManager == null)
            {
                _realAuthManager = new RealAuthManager();
            }
        }
        public bool Login(string username, string password)
        {
            if(_realAuthManager.UserExists(username) && _realAuthManager.PassIsRight(password))
            {
                return true;
            }
            return false;
        }

        public void AddUser(string user, string pass)
        {
            _realAuthManager.AddUser(user, pass);
        }
        public bool UserExists(string user)
        {
            return _realAuthManager.UserExists(user);
        }
    }
}
