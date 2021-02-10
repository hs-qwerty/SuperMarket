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
    public class BillAction : IVtBasicAction<BillType>
    {

        SqlConnection myCon = new SqlConnection(@"Data Source=Pc\SQLEXPRESS;
                                                  Initial Catalog=smarketdb;
                                                  Integrated Security= True;");

        public static string cevap,id;

        public void Add(BillType entity)
        {
            throw new NotImplementedException();

        }


        public void Add2(BillType entity)
        {
            try
            {
                myCon.Open();
                string Query = "insert into BillTbl(SellerName, BillDate, TotAmt, Loginid) values(@Name, @Date, @Amt,@id)";

                SqlCommand komut = new SqlCommand(Query, myCon);
                komut.Parameters.AddWithValue("@Name", entity.SellerName);
                komut.Parameters.AddWithValue("@Date", entity.BillDate);
                komut.Parameters.AddWithValue("@Amt", entity.TotAmt);
                komut.Parameters.AddWithValue("@id", entity.Loginid);
                komut.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("SELECT @@IDENTITY", myCon);
                cevap = cmd2.ExecuteScalar().ToString();

                myCon.Close();
                if (cevap != "")
                {

                    id = cevap;
                 

                }
                else
                {
                    throw new Exception("Admin Ulaşın");

                }
              
            }
            catch (Exception)
            {
                throw new Exception("Admin Ulaşın");

            }

        }

            public void Delete(BillType entity)
        {
            throw new NotImplementedException();
        }

        public BillType Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<BillType> GetAll()
        {
            throw new NotImplementedException();
        }

        public DataTable GetAll2(int id)
        { 
            myCon.Open();
            string query = "select * from BillTbl where loginid = '" + id + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, myCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            myCon.Close();
            return ds.Tables[0];

        }

        public void Update(BillType entity)
        {
            throw new NotImplementedException();
        }
    }
}
