using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecruiterBE.Responses;
using IRecruiterBAL;
using IRecruiterDAL;

namespace RecruiterBAL
{
    public class LoginBal : ILoginBal
    {
        #region Members

        ILoginDal _LoginDal;

        public LoginBal(ILoginDal LoginDal)
        {
            this._LoginDal = LoginDal;
        }

        #endregion

        #region Methods

        public LoginResponse UserLogin(string username, string password)
        {
            return _LoginDal.UserLogin(username, password);
        }

        #endregion
    }
}
