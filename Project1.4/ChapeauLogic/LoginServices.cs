using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;
using System.Windows.Forms;



namespace ChapeauLogic
{
    public class LoginServices
    {
        LoginDAO login_db = new LoginDAO();

        public List<login> getLogin()
        {
            try
            {
                List<login> login = login_db.GetAllLoginInfo();
                return login;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
