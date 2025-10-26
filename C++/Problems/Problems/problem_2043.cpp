#include "problem_2043.h"

class Bank {
public:
    Bank(std::vector<long long>& balance) {
        _size = balance.size();
        _accounts = balance;
    }

    bool transfer(int account1, int account2, long long money) {
        account1--;
        account2--;
        if (canAccess(account1) && canAccess(account2) && canWithdraw(account1, money))
        {
            _accounts[account1] -= money;
            _accounts[account2] += money;
            return true;
        }

        return false;
    }

    bool deposit(int account, long long money) {
        account--;
        if (canAccess(account))
        {
            _accounts[account] += money;
            return true;
        }

        return false;
    }

    bool withdraw(int account, long long money) {
        account--;
        if (canAccess(account) && canWithdraw(account, money))
        {
            _accounts[account] -= money;
            return true;
        }

        return false;
    }
private:
    int _size;
    std::vector<long long> _accounts;

    bool canAccess(int account)
    {
        return account >= 0 && account < _size;
    }
    bool canWithdraw(int account, long money)
    {
        return money <= _accounts[account];
    }
};

bool problem_2043::test() {
    std::vector<long long> balance {10, 100, 20, 50, 30};
    Bank bank(balance);
    if (!bank.withdraw(3, 10))
        return false;

    if (!bank.transfer(5, 1, 20))
        return false;
    if (!bank.deposit(5, 20))
        return false;
    if (bank.transfer(3, 4, 15))
        return false;
    if (bank.withdraw(10, 50))
        return false;

    return true;
}
