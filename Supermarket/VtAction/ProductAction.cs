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
    public class ProductAction : IVtBasicAction<ProductType>
    {

        SqlConnection myCon = new SqlConnection(@"Data Source=Pc\SQLEXPRESS;
                                                  Initial Catalog=smarketdb;
                                                  Integrated Security= True;");

        public void Add(ProductType entity)
        {
            try
            {
                myCon.Open();
                string Query = "insert into ProductTbl(Prodid, ProdName, ProdCity, ProdCat, ProdPrice) values(@Id, @Name, @city, @Category, @price)";

                SqlCommand komut = new SqlCommand(Query, myCon);
                komut.Parameters.AddWithValue("@Id", entity.Prodid);
                komut.Parameters.AddWithValue("@Name", entity.ProdName);
                komut.Parameters.AddWithValue("@city", entity.ProdCity);
                komut.Parameters.AddWithValue("@Category", entity.ProdCat);
                komut.Parameters.AddWithValue("@price", entity.ProdPrice);
                komut.ExecuteNonQuery();

                myCon.Close();
            }
            catch (Exception)
            {

                throw new Exception("Admin Ulaşın");
            }
        }

        public void Update(ProductType entity)
        {
            try
            {
                myCon.Open();
                string Query = " UPDATE ProductTbl SET ProdName = @Name, ProdCity= @City, ProdCat = @Cat, ProdPrice = @Price WHERE Prodid = @ID";

                SqlCommand komut = new SqlCommand(Query, myCon);
                komut.Parameters.AddWithValue("@Name", entity.ProdName);
                komut.Parameters.AddWithValue("@City", entity.ProdCity);
                komut.Parameters.AddWithValue("@Cat", entity.ProdCat);
                komut.Parameters.AddWithValue("@Price", entity.ProdPrice);
                komut.Parameters.AddWithValue("@ID", entity.Prodid);

                komut.ExecuteNonQuery();

                myCon.Close();
            }
            catch (Exception)
            {

                throw new Exception("Admin Ulaşın");
            }
        }

        public void Delete(ProductType entity)
        {
            try
            {
                myCon.Open();

                string Query = "Delete from ProductTbl where Prodid=@Id";

                SqlCommand komut = new SqlCommand(Query, myCon);
                komut.Parameters.AddWithValue("@Id", entity.Prodid);
                komut.ExecuteNonQuery();

                myCon.Close();

            }
            catch (Exception)
            {

                throw new Exception("Admin Ulaşın");
            }

        }

        public ProductType Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductType> GetAll()
        {
            List<ProductType> li = new List<ProductType>();

            string Query = "select * from ProductTbl";

            myCon.Open();

            SqlCommand cmd = new SqlCommand(Query, myCon);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ProductType s = new ProductType();

                s.Prodid = (int)dr["Prodid"];
                s.ProdName = dr["ProdName"].ToString();
                s.ProdCity = dr["ProdCity"].ToString();
                s.ProdCat = dr["ProdCat"].ToString();
                s.ProdPrice = dr["ProdPrice"].ToString();

                li.Add(s);


            }

            myCon.Close();
            return li;
        }


        public DataTable GetAllWhere(int cat)
        {

            string Query = "Select Prodid,ProdName,ProdPrice from ProductTbl where ProdCat=@cat";

            string ad = cat.ToString();
            myCon.Open();

            SqlCommand cmd = new SqlCommand(Query, myCon);
            cmd.Parameters.AddWithValue("@cat", ad);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("ProdName", typeof(string));
            dt.Columns.Add("ProdPrice", typeof(string));

            dt.Load(rdr);


            myCon.Close();
            return dt;

        }
       
    }
}
