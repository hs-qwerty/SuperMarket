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
   public class BillControl
    {
        BillAction _billAction = new BillAction();

        static string dd;
        public string Add(BillType billType)
        {
            try
            {
                if (billType.SellerName == "" || billType.BillDate == "" || billType.TotAmt < 0)
                {
                    throw new Exception("Veri Kontrol");
                }

                _billAction.Add2(billType);

                dd = BillAction.id;
                return dd;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


            

        }


        public DataTable Select2(int id)
        {
            return _billAction.GetAll2(id);

        }
    }
}
