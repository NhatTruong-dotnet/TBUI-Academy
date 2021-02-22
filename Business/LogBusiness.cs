using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class LogBusiness
    {
        public static void AddLog(int Processtype, string TableName, int ProcessID)
        {
            LogDAO.AddLog(Processtype, TableName, ProcessID);
        }
    }
}
