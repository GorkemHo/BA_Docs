using BABank.BaseEntities;
using BABank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABank.IRepositories
{
    public interface INumeratorRepo<T> where T : Customer
    {
        Customer GiveTicket(Customer customer);
    }
}
