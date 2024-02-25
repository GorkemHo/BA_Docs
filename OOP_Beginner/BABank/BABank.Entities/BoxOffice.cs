using BABank.Entities.Bankings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABank.Entities
{
    public class BoxOffice
    {
        public List<IndividualBanking> IndividualBankingCount { get; set; }

        public List<VIPBanking> VIPBankingCount { get; set; }

        public BoxOffice()  
        {
            IndividualBankingCount = new List<IndividualBanking>();
            VIPBankingCount = new List<VIPBanking>();
        }
    }
}
