using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UserDAO:TBUIAcademyContext
    {
        public UserDTO GetUserWithUsernameAndPassword(string username, string password)
        {
            UserDTO userBackToModel = new UserDTO();
            var list = database.T_User;
            var userFromDatabase = list.Where(item => item.Username == username && item.Password == password).FirstOrDefault();
            if (userFromDatabase != null && userFromDatabase.ID != 0)
            {
                userBackToModel.ID = userFromDatabase.ID;
                userBackToModel.Username = userFromDatabase.Username;
                userBackToModel.Name = userFromDatabase.NameSurname;
                userBackToModel.Imagepath = userFromDatabase.ImagePath;
                userBackToModel.isAdmin = userFromDatabase.isAdmin;
            }
            return userBackToModel;
        }
    }
}
  