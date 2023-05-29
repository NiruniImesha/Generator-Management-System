using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorManagementSyestem.Model
{
    class userModel
    {
        private string userName;
        private string password;
        private string userID;
        private string userType;
        private string userID_main;
        private string userType_main;


        public string UserType_main
        {
            get
            {
                return userType_main;
            }

            set
            {
                this.userType_main = value;
            }
        }
        public string UserID_main
        {
            get
            {
                return userID_main;
            }

            set
            {
                this.userID_main = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                this.password = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public string UserID
        {
            get
            {
                return userID;
            }

            set
            {
                userID = value;
            }
        }

        public string UserType
        {
            get
            {
                return userType;
            }

            set
            {
                userType = value;
            }
        }
    }
}
