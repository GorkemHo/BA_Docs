using BABank.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABank.Entities.Accounts
{
    public class VipAccount : Customer
    {
        public RowSlip Slip { get; set; }

        

        public VipAccount(int tckn) : base(tckn)
        {
        }
    }
}
