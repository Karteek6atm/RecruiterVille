using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecruiterBE.Responses;
using IRecruiterDAL;

namespace IRecruiterBAL
{
    public interface ILoginBal
    {
        LoginResponse UserLogin(string username, string password);
    }
}
