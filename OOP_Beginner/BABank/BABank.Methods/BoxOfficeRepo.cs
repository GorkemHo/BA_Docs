using BABank.BaseEntities;
using BABank.Entities;
using BABank.Entities.Bankings;
using BABank.Shared.Queues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABank.Methods
{
    public static class BoxOfficeRepo
    {
        static int vipCounter = 1000;
        static int casualCounter = 2000;

        public static Customer NextCustomer(BoxOffice currentBoxOffice, BaseBanking currentBanking)
        {
            if (VipQueue.GetInstance.Count < 0)
            {
                currentBoxOffice.VIPBankingCount.Add((VIPBanking)currentBanking);
                Customer customer = VipQueue.GetInstance.First();
                customer.SlipNumber = vipCounter;
                vipCounter++;
                return customer;
            }
            else if (AccountQueue.GetInstance.Count < 0)
            {
                currentBoxOffice.IndividualBankingCount.Add((IndividualBanking)currentBanking);
                Customer customer = AccountQueue.GetInstance.First();
                customer.SlipNumber = casualCounter;
                casualCounter++;
                return customer;
            }
            else
                throw new Exception("There is No Person in Queue");
        }
    }
}
