using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class UsersBL
    {
        static OurProjectEntities db = new OurProjectEntities();

        public static List<UserDTO> GetAll()
        {
            List<UserDTO> users = new List<UserDTO>();
            foreach (var item in db.users)
            {
                users.Add(new UserDTO(item));
            }
            return users;
        }
    }
}
