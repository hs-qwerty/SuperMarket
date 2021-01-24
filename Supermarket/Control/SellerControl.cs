using Supermarket.Type;
using Supermarket.VtAction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Control
{
    public class SellerControl
    {
        SellerAction _sellerAction = new SellerAction();

        public void Add(SellerType seller)
        {

            try
            {
                if (seller.SellerName == "" || seller.SellerPass == "" || seller.SellerPhone == "" || seller.SellerAge == "" || seller.SellerId < 0)
                {
                    throw new Exception("Veri Kontrol");
                }

                _sellerAction.Add(seller);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }


        public List<SellerType> Select()
        {

            return _sellerAction.GetAll();

        }


        public void Delete(SellerType seller)
        {

            try
            {
                if (seller.SellerId < 0)
                {
                    throw new Exception("Veri Kontrol");
                }

                _sellerAction.Delete(seller);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public void Update(SellerType seller)
        {
            try
            {
                if (seller.SellerName == "" || seller.SellerAge == "" || seller.SellerPhone == "" || seller.SellerPass == "" || seller.SellerId < 0 )
                {
                    throw new Exception("Veri Kontrol");
                }

                _sellerAction.Update(seller);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
    }
}
