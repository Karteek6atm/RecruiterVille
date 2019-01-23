using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecruiterBE.Responses;

namespace IRecruiterDAL
{
    public interface ILoginDal
    {
        LoginResponse UserLogin(string username, string password);
    }
}
