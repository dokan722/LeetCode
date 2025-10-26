using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2043 : IProblem
    {
        public bool Test()
        {
            Bank bank = new Bank(new long[] {10, 100, 20, 50, 30});
            if (!bank.Withdraw(3, 10))
                return false;

            if (!bank.Transfer(5, 1, 20))
                return false;
            if (!bank.Deposit(5, 20))
                return false;
            if (bank.Transfer(3, 4, 15))
                return false;
            if (bank.Withdraw(10, 50))
                return false;

            return true;
        }

        public class Bank
        {
            private int _size;
            private long[] _accounts;

            public Bank(long[] balance)
            {
                _size = balance.Length;
                _accounts = balance;
            }

            public bool Transfer(int account1, int account2, long money)
            {
                account1--;
                account2--;
                if (CanAccess(account1) && CanAccess(account2) && CanWithdraw(account1, money))
                {
                    _accounts[account1] -= money;
                    _accounts[account2] += money;
                    return true;
                }

                return false;
            }

            public bool Deposit(int account, long money)
            {
                account--;
                if (CanAccess(account))
                {
                    _accounts[account] += money;
                    return true;
                }

                return false;
            }

            public bool Withdraw(int account, long money)
            {
                account--;
                if (CanAccess(account) && CanWithdraw(account, money))
                {
                    _accounts[account] -= money;
                    return true;
                }

                return false;
            }

            private bool CanAccess(int account)
            {
                return account >= 0 && account < _size;
            }

            private bool CanWithdraw(int account, long money)
            {
                return money <= _accounts[account];
            }
        }
    }
}
