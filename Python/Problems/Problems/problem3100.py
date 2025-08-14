from typing import List, Dict

from .problem import Problem


class Problem3100(Problem):
    def test(self) -> bool:
        numBottles = 13
        numExchange = 6

        expected = 15

        result = self.maxBottlesDrunk(numBottles, numExchange)

        print(result)

        return result == expected

    def maxBottlesDrunk(self, numBottles: int, numExchange: int) -> int:
        result = 0

        while numBottles >= numExchange:
            numBottles -= numExchange
            result += numExchange
            numBottles += 1
            numExchange += 1

        return result + numBottles