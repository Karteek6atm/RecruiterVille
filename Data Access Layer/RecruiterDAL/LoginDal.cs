using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecruiterBE.Responses;
using IRecruiterDAL;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;
using System.Data;

namespace RecruiterDAL
{
    public class LoginDal : ILoginDal
    {
        #region Members

        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["SqlCon"]);

        #endregion

        #region Methods

        public LoginResponse UserLogin(string username, string password)
        {
            SqlParameter[] sqlparams = { new SqlParameter("@UserName", SqlDbType.VarChar, 100) { Value = username },
                                            new SqlParameter("@Password", SqlDbType.VarChar, 200) { Value = password }
                                        };
            SqlDataReader reader = null;
            LoginResponse objLoginResponse = new LoginResponse();

            try
            {
                reader = SqlHelper.ExecuteReader(con, CommandType.StoredProcedure, "USP_LoginUser", sqlparams);

                while (reader.Read())
                {
                    //objLoginResponse.Name = (string)reader["Name"];
                    //objLoginResponse.LoginId = (long)reader["LoginId"];
                    //objLoginResponse.EncryptedLoginId = CommonMethods.EncryptUserIdComId((long)reader["LoginId"]);
                    //objLoginResponse.LoginLogId = (long)reader["LoginLogId"];
                    //objLoginResponse.RoleId = (long)reader["RoleId"];
                    //objLoginResponse.RoleName = (string)reader["RoleName"];
                    //objLoginResponse.StatusId = (int)reader["StatusId"];
                    //objLoginResponse.StatusMessage = (string)reader["StatusMessage"];
                    //objLoginResponse.UserId = (long)reader["UserId"];
                    //objLoginResponse.EncryptedUserId = CommonMethods.EncryptUserIdComId((long)reader["UserId"]);
                    //objLoginResponse.CompanyId = (long)reader["CompanyId"];
                    //objLoginResponse.CompanyName = (string)reader["CompanyName"];
                    //objLoginResponse.EncryptedCompanyId = CommonMethods.EncryptUserIdComId((long)reader["CompanyId"]);
                    //objLoginResponse.ProfilePicPath = (string)reader["ProfilePicPath"];
                    //objLoginResponse.CompanyLogoPath = (string)reader["CompanyLogoPath"];
                    //objLoginResponse.PackageId = (int)reader["PackageId"];
                    //objLoginResponse.EmailId = (string)reader["EmailId"];
                    //objLoginResponse.ContactNumber = (string)reader["ContactNumber"];
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            return objLoginResponse;
        }

        #endregion
    }
}
