from typing import List

from .problem import Problem


class Problem3477(Problem):
    def test(self) -> bool:
        fruits = [3, 6, 1]
        baskets = [6, 4, 7]

        expected = 0

        result = self.numOfUnplacedFruits(fruits, baskets)

        print(result)

        return result == expected

    def numOfUnplacedFruits(self, fruits: List[int], baskets: List[int]) -> int:
        n = len(fruits)
        result = 0
        for fruit in fruits:
            bs = 0
            while bs < n and baskets[bs] < fruit:
                bs += 1
            if bs == n:
                continue
            baskets[bs] = 0
            result += 1


        return n - result