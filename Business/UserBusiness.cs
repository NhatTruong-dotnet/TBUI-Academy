using DataAccess;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class UserBusiness
    {
        UserDAO userDAO = new UserDAO();
        public UserDTO GetUserWithUsernameAndPassword(UserDTO user)
        {
            UserDTO userBackToUI = new UserDTO();
            userBackToUI = userDAO.GetUserWithUsernameAndPassword(user.Username, user.Password);
            return userBackToUI;
        }
    }
}
