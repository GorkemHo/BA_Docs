using BABank.Entities.Accounts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABank.Shared.Queues
{
    public class VipQueue : BaseQueue<VipAccount>
    {
        private static VipQueue _vipList;

        public static VipQueue GetInstance
        {
            get { return _vipList is null ? _vipList = new VipQueue() : _vipList; }
        }

        private VipQueue()
        {
            _list = new Queue<VipAccount>();
        }
    }
}
