using Supermarket.Type;
using Supermarket.VtAction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Control
{
    public class BillDetailsControl
    {

        BillDetailsAction _billDetailsAction = new BillDetailsAction();

        public void Add(BillDetailsType billDetailsType)
        {

            try
            {
                if (billDetailsType.ProdName == "" || billDetailsType.ProdTotal == "" || billDetailsType.ProdId < 0 || billDetailsType.BillTblId < 0)
                {
                    throw new Exception("Veri Kontrol");
                }

                _billDetailsAction.Add(billDetailsType);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }


        public List<BillDetailsType> Select(int id,int buildid)
        {

            return _billDetailsAction.GetAll2(id,buildid);
        }
    }
}
