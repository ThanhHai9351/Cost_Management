using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_Account
    {
        DAL_Account dal_ac = new DAL_Account();
        public BLL_Account()
        {

        }

        public bool loginAccount(string username, string password)
        {
            return dal_ac.loginAccount(username, password);
        }
    }
}
