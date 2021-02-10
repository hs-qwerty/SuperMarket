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
    public class CategoryAction : IVtBasicAction<CategoryType>
    {


        SqlConnection myCon = new SqlConnection(@"Data Source=Pc\SQLEXPRESS;
                                                  Initial Catalog=smarketdb;
                                                  Integrated Security= True;");

        public void Add(CategoryType entity)
        {
            try
            {
                myCon.Open();
                string Query = "insert into CategoryTbl(CatId, CatName, CatDesc) values(@Id, @Name, @Desc)";

                SqlCommand komut = new SqlCommand(Query, myCon);
                komut.Parameters.AddWithValue("@Id", entity.CatId);
                komut.Parameters.AddWithValue("@Name", entity.CatName);
                komut.Parameters.AddWithValue("@Desc", entity.CatDesc);
                komut.ExecuteNonQuery();

                myCon.Close();
            }
            catch (Exception)
            {

                throw new Exception("Admin Ulaşın");
            }

        }

    
        public List<CategoryType> GetAll()
        {
            List<CategoryType> li = new List<CategoryType>();

            string Query = "select * from CategoryTbl";

            myCon.Open();

            SqlCommand cmd = new SqlCommand(Query, myCon);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CategoryType s = new CategoryType();

                s.CatId = (int)dr["CatId"];
                s.CatName = dr["CatName"].ToString();
                s.CatDesc= dr["CatDesc"].ToString();
                
                li.Add(s);


            }

            myCon.Close();
            return li;

        }

       
        public DataTable GetAll2()
        {
            myCon.Open();
            string query = "select * from CategoryTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, myCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            myCon.Close();
            return ds.Tables[0];

        }

        public DataTable GetAllComboBox()
        {
            myCon.Open();
            string Query = "select CatName from CategoryTbl";

            SqlCommand komut = new SqlCommand(Query, myCon);
            SqlDataReader rdr;
            rdr = komut.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(rdr);

            myCon.Close();

            return dt;
            

        }


        public void Update(CategoryType entity)
        {
            try
            {
             
                myCon.Open();
                string Query = " UPDATE CategoryTbl SET CatName = @Name, CatDesc= @Desc WHERE CatId = @ID";

                SqlCommand komut = new SqlCommand(Query, myCon);
                komut.Parameters.AddWithValue("@Name", entity.CatName);
                komut.Parameters.AddWithValue("@Desc", entity.CatDesc);
                komut.Parameters.AddWithValue("@ID", entity.CatId);

                komut.ExecuteNonQuery();

                myCon.Close();
            }
            catch (Exception)
            {

                throw new Exception("Admin Ulaşın");
            }
        }

        public void Delete(CategoryType entity)
        {
            try
            {
                myCon.Open();

                string Query = "Delete from CategoryTbl where CatId=@Id";

                SqlCommand komut = new SqlCommand(Query, myCon);
                komut.Parameters.AddWithValue("@Id", entity.CatId);
                komut.ExecuteNonQuery();

                myCon.Close();

            }
            catch (Exception)
            {

                throw new Exception("Admin Ulaşın");
            }



        }

        public CategoryType Get(int id)
        {
            throw new NotImplementedException();
        }


    }
}
