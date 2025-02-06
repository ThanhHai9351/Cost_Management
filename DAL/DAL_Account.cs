using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Account
    {
        QLGTDataContext qlgt = new QLGTDataContext();
        public DAL_Account()
        {

        }

        public bool loginAccount(string us, string pass)
        {
            var account = qlgt.t_Accounts
                     .FirstOrDefault(a => a.staff_id == us && a.password == pass);
            return account != null;
        }
    }
}
