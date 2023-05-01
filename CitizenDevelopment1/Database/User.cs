using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitizenDevelopment1
{
    public class User
    {
        public int Id { get; set; }

        public string applicationName, userName, comment;
        public string ApplicationName
        {
            get { return applicationName; }
            set { applicationName = value; }
        }

        public string UserName

        {
            get { return userName; }
            set { userName = value; }
        }

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        
        public User(string applicationName, string userName, string comment)
        {
            this.applicationName = applicationName;
            this.userName = userName;
            this.comment = comment;
        }
    }
}
