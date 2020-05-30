using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class login
    {
        public int employeeID { get; set; }
        public int loginCode { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string role { get; set; }

        public login(int loginCode)
        {
            this.loginCode = loginCode;
        }
    }
}
