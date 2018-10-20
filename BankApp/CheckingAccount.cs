using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    /// <summary>
    /// This project is to create a bank account.
    /// You can write a summary in multiple lines.
    /// </summary>
    class CheckingAccount : Account
    {
      #region Properties
      #endregion

	    public CheckingAccount(int id, string email, string name, decimal balance) {
	    	base(id, email, name, "Checking", balance);
	    }
    }
}
