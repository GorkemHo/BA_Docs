using BABank.Entities.Accounts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABank.Shared.RegisteredAccounts
{
    public class RegisteredVipAccounts<VipAccount> : ICollection<VipAccount>
    {
        private static RegisteredVipAccounts<VipAccount> _registeredVipAccountList { get; set; }

        public static RegisteredVipAccounts<VipAccount> GetInstance
        {
            get { return _registeredVipAccountList is null ? _registeredVipAccountList = new RegisteredVipAccounts<VipAccount>() : _registeredVipAccountList; }
        }

        private RegisteredVipAccounts()
        {
            _registeredVipAccountList = new RegisteredVipAccounts<VipAccount>();
        }

        public int Count => _registeredVipAccountList.Count;

        public bool IsReadOnly => ((ICollection<Account>)_registeredVipAccountList).IsReadOnly;


        public void Add(VipAccount item)
        {
            _registeredVipAccountList.Add(item);
        }

        public void Clear()
        {
            _registeredVipAccountList?.Clear();
        }

        public bool Contains(VipAccount item)
        {
            return _registeredVipAccountList.Contains(item);
        }

        public void CopyTo(VipAccount[] array, int arrayIndex)
        {
            _registeredVipAccountList.CopyTo(array, arrayIndex);
        }

        public bool Remove(VipAccount item)
        {
            return (_registeredVipAccountList.Remove(item));
        }

        public IEnumerator<VipAccount> GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _registeredVipAccountList.GetEnumerator();
        }
    }
}
