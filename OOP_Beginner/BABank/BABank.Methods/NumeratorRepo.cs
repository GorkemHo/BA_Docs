using BABank.BaseEntities;
using BABank.Entities;
using BABank.Entities.Accounts;
using BABank.IRepositories;
using BABank.Shared.Queues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABank.Methods
{

    public class NumeratorRepo<T> where T : Customer , INumeratorRepo<T>
    {
        RowSlip rowSlip = new RowSlip();
        public Customer GiveTicket(Customer customer)
        {
            if (customer is Account)
            {
                AccountQueue.GetInstance.Add((Account)customer);
                customer.SlipNumber = AccountQueue.GetInstance.Count;
            }
            
            else if (customer is VipAccount)
            {
                VipQueue.GetInstance.Add((VipAccount)customer);
                customer.SlipNumber = VipQueue.GetInstance.Count;
            }

            return customer;

        }
    }
}
