using Supermarket.Type;
using Supermarket.VtAction.VtBasicAction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.VtAction
{
    public class LoginAction : IVtBasicAction<LoginType>
    {

        SqlConnection myCon = new SqlConnection(@"Data Source=Pc\SQLEXPRESS;
                                                  Initial Catalog=smarketdb;
                                                  Integrated Security= True;");

        public void Add(LoginType entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(LoginType entity)
        {
            throw new NotImplementedException();
        }

        public LoginType Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<LoginType> GetAll()
        {
            throw new NotImplementedException();
        }

        public DataTable Log(LoginType entity)
        {

            try
            {
                
                myCon.Open();

                string Query = "select * from LoginTbl where LoginName=@ad and LoginPass=@pass and LoginStatus=@status";

                SqlCommand komut = new SqlCommand(Query, myCon);
                komut.Parameters.AddWithValue("@ad", entity.LoginName);
                komut.Parameters.AddWithValue("@pass", entity.LoginPass);
                komut.Parameters.AddWithValue("@status", entity.LoginStatus);
                komut.ExecuteNonQuery();

                DataTable Veri = new DataTable();
                SqlDataAdapter MyDa = new SqlDataAdapter(komut);

                MyDa.Fill(Veri);

                int i = 0;

                i = Convert.ToInt32(Veri.Rows.Count);

                if (i == 0)
                {
                    throw new Exception("Kullanıcı Adı veya Parola Yanlış.");
                    myCon.Close();
                }
                else
                {

                    Veri.Rows[0]["LoginName"].ToString();
                    Veri.Rows[0]["LoginId"].ToString();
                    Veri.Rows[0]["LoginStatus"].ToString();
                    myCon.Close();

                }
                myCon.Close();
                return Veri;
                


            }
            catch (Exception)
            {

                throw;
            }


        }

        public void Update(LoginType entity)
        {
            throw new NotImplementedException();
        }
    }
}
