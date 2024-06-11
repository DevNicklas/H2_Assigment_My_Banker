using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assigment_My_Banker.Model
{
	public class Bank
	{
		private string _bankName;

		public Bank(string bankName)
		{
			_bankName = bankName;
		}

		public string BankName  { get  {  return _bankName;  }  }
	}
}
