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
    public class SellerAction : IVtBasicAction<SellerType>
    {

        SqlConnection myCon = new SqlConnection(@"Data Source=Pc\SQLEXPRESS;
                                                  Initial Catalog=smarketdb;
                                                  Integrated Security= True;");

        public void Add(SellerType entity)
        {
            try
            {
                myCon.Open();
                string Query = "insert into SellerTbl(SellerId, SellerName, SellerAge, SellerPhone, SellerPass) values(@Id, @Name, @Desc, @Phone, @Pass)";

                SqlCommand komut = new SqlCommand(Query, myCon);
                komut.Parameters.AddWithValue("@Id", entity.SellerId);
                komut.Parameters.AddWithValue("@Name", entity.SellerName);
                komut.Parameters.AddWithValue("@Desc", entity.SellerAge);
                komut.Parameters.AddWithValue("@Phone", entity.SellerPhone);
                komut.Parameters.AddWithValue("@Pass", entity.SellerPass);
                komut.ExecuteNonQuery();

                myCon.Close();
            }
            catch (Exception)
            {

                throw new Exception("Admin Ulaşın");
            }

        }


        public void Delete(SellerType entity)
        {
            try
            {
                myCon.Open();

                string Query = "Delete from SellerTbl where SellerId=@Id";

                SqlCommand komut = new SqlCommand(Query, myCon);
                komut.Parameters.AddWithValue("@Id", entity.SellerId);
                komut.ExecuteNonQuery();

                myCon.Close();

            }
            catch (Exception)
            {

                throw new Exception("Admin Ulaşın");
            }

        }

        public SellerType Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<SellerType> GetAll()
        {
            List<SellerType> li = new List<SellerType>();

            string Query = "select * from SellerTbl";

            myCon.Open();

            SqlCommand cmd = new SqlCommand(Query, myCon);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                SellerType s = new SellerType();

                s.SellerId = (int)dr["SellerId"];
                s.SellerName = dr["SellerName"].ToString();
                s.SellerAge = dr["SellerAge"].ToString();
                s.SellerPhone = dr["SellerPhone"].ToString();
                s.SellerPass = dr["SellerPass"].ToString();

                li.Add(s);


            }

            myCon.Close();
            return li;
        }

        public void Update(SellerType entity)
        {
            try
            {
                myCon.Open();
                string Query = " UPDATE SellerTbl SET SellerName = @Name, SellerAge= @Age, SellerPhone= @Phone, SellerPass= @Pass WHERE SellerId = @ID";

                SqlCommand komut = new SqlCommand(Query, myCon);
                komut.Parameters.AddWithValue("@Name", entity.SellerName);
                komut.Parameters.AddWithValue("@Age", entity.SellerAge);
                komut.Parameters.AddWithValue("@Phone", entity.SellerPhone);
                komut.Parameters.AddWithValue("@Pass", entity.SellerPass);
                komut.Parameters.AddWithValue("@ID", entity.SellerId);

                komut.ExecuteNonQuery();

                myCon.Close();
            }
            catch (Exception)
            {

                throw new Exception("Admin Ulaşın");
            }
        }
    }
}
