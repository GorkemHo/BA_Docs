using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABank.BaseEntities
{
    public abstract class Human
    {
        private int _tckn;

        public int TCKN
        {
            get { return _tckn; }
            set { _tckn = value; }
        }

        public string NameSurname { get; set; }

        public int SlipNumber { get; set; }

        public Human(int tckn)
        {
            _tckn = tckn;
        }

        
    }
}
