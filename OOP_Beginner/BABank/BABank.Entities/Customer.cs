
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABank.BaseEntities
{
    public abstract class Customer : Human
    {
        

        public Customer(int tckn) : base(tckn)
        {

        }
    }
}
