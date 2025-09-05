from typing import List

from .problem import Problem


class Problem2749(Problem):
    def test(self) -> bool:
        num1 = 3
        num2 = -2

        expected = 3

        result = self.makeTheIntegerZero(num1, num2)

        print(result)

        return result == expected

    def makeTheIntegerZero(self, num1: int, num2: int) -> int:
        i = 0
        while True:
            next = num1 - i * num2
            if next < i:
                return -1
            count = next.bit_count()
            if count <= i:
                return i
            i += 1