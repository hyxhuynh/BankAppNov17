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
    class Account
    {
        #region Properties
        public int AccountNumber { get; set; }
        public string EmailAddress { get; set; }
        public string AccountName { get; set; }
        public string AccountType { get; set; }
        public decimal Balance { get; set; }
        #endregion

	public Account(int id, string email, string name, string type, decimal balance) {
		AccountNumber = id;
		EmailAddress = email;
		AccountName = name;
		AccountType = type;
		Balance = balance;
	}

        public decimal CalculateInterest() {
            return 0.1 * Balance;
        }
    
    }
}
