using SA43Team05B.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA43Team05B.Controller
{
    public class Transaction
    {
        LMSEntities dbContext;
        public Transaction()
        {
            dbContext = new LMSEntities();
        }
    }
}
