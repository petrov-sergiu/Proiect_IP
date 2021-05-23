using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Authentication
{
    class Authentication
    {
        private static List<User> _users;
        private static User _currentUser;
        private const string Path = "Secure\\";

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
        // read from file users.txt
        // if user exists error messae
        // if user does not exist write user to file users.txt

        // read file from users.txt
        // if user does not exist error message
        // if user exists redirect to main form signed as current user
        public static bool Login(string username, string password)
        {
            foreach (User u in _users)
            {
                if (u.Name.Equals(username) && u.PassHash.Equals(Cryptography.HashString(password)))
                {
                    _currentUser = u;
                    return true;
                }
            }
            return false;
        }

        public static void AddUser(string user, string pass)
        {
            foreach (User u in _users)
            {
                if (u.Name.Equals(user))
                {
                    MessageBox.Show("Utilizatorul exista deja!");
                    return;
                }
            }
            User newUser = new User(user, Cryptography.HashString(pass));
            _users.Add(newUser);
            SaveUsers();
            MessageBox.Show("Utilizatorul a fost adaugat cu succes!");
        }

        private static void SaveUsers()
        {
            StreamWriter sw = new StreamWriter(Path + "utilizatori.txt");
            foreach (User u in _users)
            {
                sw.WriteLine(u.Name + "\t" + u.PassHash);
            }
            sw.Close();
        }
    }
}
