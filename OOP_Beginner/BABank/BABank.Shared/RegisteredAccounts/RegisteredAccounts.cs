using BABank.Shared.Queues;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABank.Shared.RegisteredAccounts
{
    public class RegisteredAccounts<Account> : ICollection<Account>
    {
        private static RegisteredAccounts<Account> _registeredAccountList { get; set; }

        public static RegisteredAccounts<Account> GetInstance
        {
            get { return _registeredAccountList is null ? _registeredAccountList = new RegisteredAccounts<Account>() : _registeredAccountList; }
        }

        private RegisteredAccounts()
        {
            _registeredAccountList = new RegisteredAccounts<Account>();
        }


        public int Count => _registeredAccountList.Count;

        public bool IsReadOnly => ((ICollection<Account>)_registeredAccountList).IsReadOnly;


        public void Add(Account item)
        {
            _registeredAccountList.Add(item);
        }

        public void Clear()
        {
            _registeredAccountList?.Clear();
        }

        public bool Contains(Account item)
        {
            return _registeredAccountList.Contains(item);
        }

        public void CopyTo(Account[] array, int arrayIndex)
        {
            _registeredAccountList.CopyTo(array, arrayIndex);
        }

        public bool Remove(Account item)
        {
            return (_registeredAccountList.Remove(item));
        }

        public IEnumerator<Account> GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _registeredAccountList.GetEnumerator();
        }
    }
}
