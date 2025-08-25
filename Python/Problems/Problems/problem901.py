from typing import List

from .problem import Problem


class StockSpanner:
    def __init__(self):
        self.spanStack = []

    def next(self, price: int) -> int:
        span = 1
        while self.spanStack and self.spanStack[-1][0] <= price:
            item = self.spanStack.pop()
            span += item[1]
        self.spanStack.append([price, span])
        return span


class Problem901(Problem):
    def test(self) -> bool:
        stockSpanner = StockSpanner()
        if stockSpanner.next(100) != 1:
            return False
        if stockSpanner.next(80) != 1:
            return False
        if stockSpanner.next(60) != 1:
            return False
        if stockSpanner.next(70) != 2:
            return False
        if stockSpanner.next(60) != 1:
            return False
        if stockSpanner.next(75) != 4:
            return False
        if stockSpanner.next(85) != 6:
            return False

        return True