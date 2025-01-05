using System;

namespace TerminalEventApp
{
    class Bank
    {
        public decimal CashAccount { get; set; }

        /// <summary>
        /// Adds money to CashAccount
        /// </summary>
        /// <param name="money"></param>
        public void PutsMoney(decimal money)
        {
            CashAccount += money;
        }
        /// <summary>
        /// Substracts money from CashAccount
        /// </summary>
        /// <param name="money"></param>
        public void WithdrawsMoney(decimal money)
        {
            CashAccount -= money;
        }
        /// <summary>
        /// Shows CashAccount bill
        /// </summary>
        public void ShowBill()
        {
            Console.WriteLine(CashAccount);
        }
    }
}