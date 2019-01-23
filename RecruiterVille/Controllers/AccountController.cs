using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using RecruiterBE;
using IRecruiterBAL;

namespace RecruiterVille.Controllers
{
    public class AccountController : Controller
    {
        #region Members

        //ILoginBal _LoginBal;
        
        //public AccountController(ILoginBal LoginBal)
        //{
        //    _LoginBal = LoginBal;
        //}

        #endregion

        #region Actions & Members

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        #endregion
    }
}