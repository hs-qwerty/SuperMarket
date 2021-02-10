using Supermarket.Type;
using Supermarket.VtAction.VtBasicAction;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.VtAction
{
    public class BillDetailsAction : IVtBasicAction<BillDetailsType>
    {

        SqlConnection myCon = new SqlConnection(@"Data Source=Pc\SQLEXPRESS;
                                                  Initial Catalog=smarketdb;
                                                  Integrated Security= True;");

        public void Add(BillDetailsType entity)
        {
            try
            {
                myCon.Open();
                string Query = "insert into BillDetailsTbl(BillTblId, ProdId, ProdName, ProdTotal,UserId) values(@biltbl, @prodid, @name,@total,@id)";

                SqlCommand komut = new SqlCommand(Query, myCon);
                komut.Parameters.AddWithValue("@biltbl", entity.BillTblId);
                komut.Parameters.AddWithValue("@prodid", entity.ProdId);
                komut.Parameters.AddWithValue("@name", entity.ProdName);
                komut.Parameters.AddWithValue("@total", entity.ProdTotal);
                komut.Parameters.AddWithValue("@id", entity.UserId);
                komut.ExecuteNonQuery();


                myCon.Close();

            }
            catch (Exception)
            {
                throw new Exception("Admin Ulaşın");

            }
        }

        public void Delete(BillDetailsType entity)
        {
            throw new NotImplementedException();
        }

        public BillDetailsType Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<BillDetailsType> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<BillDetailsType> GetAll2(int id,int billid)
        {
            List<BillDetailsType> li = new List<BillDetailsType>();

            string Query = "select * from BillDetailsTbl where BillTblId = '" + billid +"'";

            myCon.Open();

            SqlCommand cmd = new SqlCommand(Query, myCon);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                BillDetailsType s = new BillDetailsType();

                s.BillDetailsId = (int)dr["BillDetailsId"];
                s.BillTblId = (int)dr["BillTblId"];
                s.ProdId = (int)dr["ProdId"];
                s.ProdName = dr["ProdName"].ToString();
                s.ProdTotal = dr["ProdTotal"].ToString();

                li.Add(s);


            }

            myCon.Close();
            return li;

        }



        public void Update(BillDetailsType entity)
        {
            throw new NotImplementedException();
        }
    }
}
