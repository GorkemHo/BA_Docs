using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABank.BaseEntities
{
    public abstract class Employee : Human
    {
        public Employee(int tckn) : base(tckn)
        {

        }
    }
}
