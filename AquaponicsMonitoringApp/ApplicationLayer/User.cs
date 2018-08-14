using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaponicsMonitoringApp.ApplicationLayer
{
    /// <summary>
    /// This class represents users that are allowed full access to the system.
    /// Users will be required to log in whenever the settings and customization of sensors are changed.
    /// </summary>
    public class User
    {
        private int userID;
        private string username;
        private string password;
        private string email;
        private string securityQ;
        private string securityA;


        public User(string username, string password, int userID = 0)
        {
            this.UserID = userID;
            this.Username = username;
            this.Password = password;
        }
        public User(string username, string password, string email="", string securityQ="", string securityA="", int userID = 0)
        {
            this.UserID = userID;
            this.Username = username;
            this.Password = password;
            this.Email = email;
            this.SecurityQ = securityQ;
            this.SecurityA = securityA;
        }

        public User()
        {
        }

        public string SecurityA
        {
            get { return securityA; }
            set { securityA = value; }
        }


        public string SecurityQ
        {
            get { return securityQ; }
            set { securityQ = value; }
        }


        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }


        public string Username
        {
            get { return username; }
            set { username = value; }
        }


        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            User user = obj as User;
            if ((object)user == null)
            {
                return false;
            }
            return ((this.UserID == user.UserID) && (this.Username == user.Username) && (this.Password == user.Password)&&(this.Email==user.Email)&&(this.SecurityQ==user.SecurityQ)&&(this.SecurityA==user.SecurityA));
        }

        public override int GetHashCode()
        {
            return this.UserID.GetHashCode() ^ this.Username.GetHashCode() ^ this.Password.GetHashCode()^this.Email.GetHashCode()^this.SecurityQ.GetHashCode()^this.SecurityA.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void newUser()
        {
            DataAccessLayer.DataHandler dh = new DataAccessLayer.DataHandler();
            dh.insertUser(this);
        }

        public void updateUsers()
        {
            DataAccessLayer.DataHandler dh = new DataAccessLayer.DataHandler();
            dh.updateUser(this);
        }
    }
}
