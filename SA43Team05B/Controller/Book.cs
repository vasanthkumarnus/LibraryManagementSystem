using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SA43Team05B.Model;

namespace SA43Team05B.Controller
{
    public class Book
    {
        LMSEntities dbContext;
        public Book()
        {
            dbContext = new LMSEntities();
        }
    }
}
