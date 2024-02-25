using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BABank.Entities.Accounts;

namespace BABank.Shared.Queues
{
    public class AccountQueue : BaseQueue<Account>
    {
        private static AccountQueue _vipList;

        public static AccountQueue GetInstance
        {
            get { return _vipList is null ? _vipList = new AccountQueue() : _vipList; }
        }

        private AccountQueue()
        {
            _list = new Queue<Account>();
        }
    }
}
