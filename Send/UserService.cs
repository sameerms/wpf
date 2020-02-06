using System;
using System.Collections.Generic;
using System.Text;

namespace Send
{
    internal class UserService
    {
        public UserService()
        {

        }
        internal List<User> GetAllUsersToSend() { 
         
        List<User> userList = new List<User>();
        userList.Add( new User { FirstName = "abc", LastName = "hfhdujf", EmailAddress = "jdiogfjdgfo"});
        userList.Add( new User { FirstName = "jdgh", LastName = "uohdgiudgh", EmailAddress = "gfjsgj"});

        return userList;
        }
    }
}
