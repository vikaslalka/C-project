using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTVikasLalka
{
    class LogIn
    {
        int id;
        String un;
        String pw;
         
        public LogIn(int id,String un,String pw)
        {
            this.id = id;
            this.un = un;
            this.pw = pw;
        }
        public String getUN()
        {
            return un;
        }
        public String getPW()
        {
            return pw;
        }
    }
}
