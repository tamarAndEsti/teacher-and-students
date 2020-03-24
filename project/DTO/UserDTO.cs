using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DTO
{
    public class UserDTO
    {
        public int userId { get; set; }
        public string userFirstName { get; set; }
        public string userLastName { get; set; }
        public string userPassword { get; set; }
        public string userEmail { get; set; }
        public int userStatus { get; set; }

        public UserDTO(users u)
        {
            userId = u.userId;
            userFirstName = u.userFirstName;
            userLastName = u.userLastName;
            userPassword = u.userPassword;
            userEmail = u.userEmail;
            userStatus = u.userStatus;
        }

        public users ToDAL()
        {
            return new users()
            {
                userId = userId,
                userFirstName = userFirstName,
                userLastName = userLastName,
                userPassword = userPassword,
                userEmail = userEmail,
                userStatus = userStatus
            };
        }
    }
}
