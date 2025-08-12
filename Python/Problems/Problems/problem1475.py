from typing import List, Dict

from .problem import Problem


class Problem1475(Problem):
    def test(self) -> bool:
        prices = [8, 4, 6, 2, 3]

        expected = [4, 2, 4, 2, 3]

        result = self.finalPrices(prices)

        return expected == result

    def finalPrices(self, prices: List[int]) -> List[int]:
        n = len(prices)

        stack = []

        for i in range(n):
            while stack and prices[stack[-1]] >= prices[i]:
                prices[stack.pop()] -= prices[i]
            stack.append(i)

        return prices