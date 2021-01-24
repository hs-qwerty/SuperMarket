using Supermarket.Type;
using Supermarket.VtAction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Control
{
   public class LoginControl
    {

        LoginAction _loginAction = new LoginAction();

        public DataTable Select(LoginType login)
        {

           return _loginAction.Log(login);

        }
    }
}
