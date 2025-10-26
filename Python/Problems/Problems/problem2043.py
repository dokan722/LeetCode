import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Bank:
    def __init__(self, balance: List[int]):
        self.accounts = balance
        self.size = len(balance)

    def transfer(self, account1: int, account2: int, money: int) -> bool:
        account1 -= 1
        account2 -= 1
        if self.canAccess(account1) and self.canAccess(account2) and self.canWithdraw(account1, money):
            self.accounts[account1] -= money
            self.accounts[account2] += money
            return True
        return False

    def deposit(self, account: int, money: int) -> bool:
        account -= 1
        if self.canAccess(account):
            self.accounts[account] += money
            return True
        return False

    def withdraw(self, account: int, money: int) -> bool:
        account -= 1
        if self.canAccess(account) and self.canWithdraw(account, money):
            self.accounts[account] -= money
            return True
        return False

    def canAccess(self, account: int) -> bool:
        return 0 <= account < self.size

    def canWithdraw(self, account: int, money: int) -> bool:
        return money <= self.accounts[account]

class Problem2043(Problem):
    def test(self) -> bool:
        bank = Bank([10, 100, 20, 50, 30])
        if not bank.withdraw(3, 10):
            return False
        if not bank.transfer(5, 1, 20):
            return False
        if not bank.deposit(5, 20):
            return False
        if bank.transfer(3, 4, 15):
            return False
        if bank.withdraw(10, 50):
            return False

        return True