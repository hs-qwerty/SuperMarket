using Supermarket.Type;
using Supermarket.VtAction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Control
{

    public class ProductControl
    {

        ProductAction _productAction = new ProductAction();


        public void Add(ProductType product)
        {

            try
            {
                if (product.ProdName == "" || product.ProdCity == "" || product.ProdPrice == "" || product.ProdCat == "" || product.Prodid < 0)
                {
                    throw new Exception("Veri Kontrol");
                }

                _productAction.Add(product);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


        public List<ProductType> Select()
        {

            return _productAction.GetAll();
        }

        public void Update(ProductType product)
        {
            try
            {
                if (product.ProdName == "" || product.ProdCity == "" || product.ProdPrice == "" || product.ProdCat == "" || product.Prodid < 0)
                {
                    throw new Exception("Veri Kontrol");
                }

                _productAction.Update(product);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }


        public void Delete(ProductType product)
        {
            try
            {
                if (product.Prodid < 0)
                {
                    throw new Exception("Veri Kontrol");
                }

                _productAction.Delete(product);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }



        }



        public DataTable SelectWhere(int Cat)
        {

            return _productAction.GetAllWhere(Cat);
        }
    }
}
