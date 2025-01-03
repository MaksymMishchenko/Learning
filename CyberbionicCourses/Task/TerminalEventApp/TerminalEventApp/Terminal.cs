using System;

namespace TerminalEventApp
{
    class Terminal
    {
        private readonly Bank _cashAccount;
        public event PutMoneyDelegate PutMoney = null;
        public event GetMoneyDelegate GetMoney = null;

        public Terminal(decimal money)
        {
            _cashAccount = new Bank{CashAccount = money};
        }

        /// <summary>
        /// Puts money to Bank
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public bool PutsMoney(decimal money)
        {
            _cashAccount.PutsMoney(money);
            return true;
        }
        /// <summary>
        /// Gets money from Bank
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public bool WithdrawsMoney(decimal money)
        {
            _cashAccount.WithdrawsMoney(money);
            return true;
        }

        /// <summary>
        /// Shows Bank bill
        /// </summary>
        public void ShowBill()
        {
            _cashAccount.ShowBill();
        }

        /// <summary>
        /// Starts event which puts money to Bank
        /// </summary>
        /// <param name="money"></param>
        public void PutMoneyInvoke(decimal money)
        {
            PutMoney.Invoke(money);
        }

        /// <summary>
        /// Starts event which get money from Bank
        /// </summary>
        /// <param name="money"></param>
        public void GetMoneyInvoke(decimal money)
        {
            GetMoney.Invoke(money);
        }
    }
}
