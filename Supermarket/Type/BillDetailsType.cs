using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Type
{
    public class BillDetailsType
    {
        public int BillDetailsId { get; set; }
        public int BillTblId { get; set; }
        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public string ProdTotal { get; set; }
        public int UserId { get; set; }
    }
}
