using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABank.BaseEntities
{
    public abstract class BaseEntity
    {
		private int _id;

		public int ID
		{
			get { return _id; }
			set { _id = value; }
		}

	}
}
