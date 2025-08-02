import sys
from typing import List

from .problem import Problem


class Problem2561(Problem):
    def test(self) -> bool:
        basket1 = [4, 2, 2, 2]
        basket2 = [1, 4, 1, 2]

        expected = 1

        result = self.minCost(basket1, basket2)

        print(result)

        return expected == result

    def minCost(self, basket1: List[int], basket2: List[int]) -> int:
        n = len(basket1)
        counts1 = {}
        counts2 = {}
        minConst = sys.maxsize
        for i in range(n):
            if basket1[i]  in counts1:
                counts1[basket1[i]] += 1
            else:
                counts1[basket1[i]] = 1
                counts2[basket1[i]] = 0
            if basket2[i] in counts2:
                counts2[basket2[i]] += 1
            else:
                counts2[basket2[i]] = 1
                counts1[basket2[i]] = 0
            if basket1[i] < minConst:
                minConst = basket1[i]
            if basket2[i] < minConst:
                minConst = basket2[i]

        first = []
        second = []
        for key in counts1.keys():
            toSwap = counts1[key] - counts2[key]
            if toSwap % 2 != 0:
                return -1
            if toSwap > 0:
                first += [key] * (toSwap // 2)
            elif toSwap < 0:
                second += [key] * (-toSwap // 2)

        first.sort()
        second.sort()

        result = 0
        m = len(first)
        for i in range(m):
            result += min(min(first[i], second[m - 1 - i]), 2 * minConst)

        return result