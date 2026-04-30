import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2806(Problem):
    def test(self) -> bool:
        purchaseAmount = 9

        expected = 90

        result = self.accountBalanceAfterPurchase(purchaseAmount)

        print(result)

        return result == expected

    def accountBalanceAfterPurchase(self, purchaseAmount: int) -> int:
        return 100 - (purchaseAmount + 5) // 10 * 10