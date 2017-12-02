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
        public string AcountType { get; set; }
        public decimal Balance { get; set; }
        #endregion
    }
}
