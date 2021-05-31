using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Authentication
{
    internal class RealAuthManager : IAuthManager
    {
        private static List<User> _users;
        private const string Path = "Documents\\";
        public struct User
        {
            public readonly string Name;
            public readonly string PassHash;

            public User(string name, string passHash)
            {
                Name = name;
                PassHash = passHash;
            }
        }
        public RealAuthManager()
        {
            //open document, read data, add to list
            _users = new List<User>();
            StreamReader line = new StreamReader(Path + "users.txt");
            while (line.Peek() != -1)
            {
                string[] toks = line.ReadLine().Split('\t');
                User user = new User(toks[0], toks[1]);
                _users.Add(user);
            }
            line.Close();
        }
        public void SaveUser()
        {
            StreamWriter sw = new StreamWriter(Path + "users.txt");
            foreach (User u in _users)
            {
                sw.WriteLine(u.Name + "\t" + u.PassHash);
            }
            sw.Close();
        }
        public bool UserExists(string user)
        {
            foreach (User u in _users)
            {
                if (u.Name.Equals(user))
                {
                    return true;
                }
            }
            return false;
        }
        public void AddUser(string user, string pass)
        {
            User newUser = new User(user, Cryptography.HashString(pass));
            _users.Add(newUser);
            SaveUser();
        }
        public bool PassIsRight(string password)
        {
            foreach (User u in _users)
            {
                if (u.PassHash.Equals(Cryptography.HashString(password)))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
