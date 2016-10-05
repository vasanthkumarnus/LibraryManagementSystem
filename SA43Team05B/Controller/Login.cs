using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SA43Team05B.Model;

//Written By Nyeint Nyeint Khin

namespace SA43Team05B.Controller
{
    class Login
    {
        LMSEntities dbContext;

        public bool checkLogin(String userName, String password)
        {
            dbContext = new LMSEntities();

            if (dbContext.Users.Any(x => x.UserName == userName && x.Password == password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
