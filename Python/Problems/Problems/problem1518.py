from typing import List, Dict

from .problem import Problem


class Problem1518(Problem):
    def test(self) -> bool:
        numBottles = 9
        numExchange = 3

        expected = 13

        result = self.numWaterBottles(numBottles, numExchange)

        print(result)

        return result == expected

    def numWaterBottles(self, numBottles: int, numExchange: int) -> int:
        result = 0

        while numBottles >= numExchange:
            newBottles = numBottles // numExchange
            remBottles = numBottles % numExchange
            result += numBottles - remBottles
            numBottles = remBottles + newBottles

        return result + numBottles