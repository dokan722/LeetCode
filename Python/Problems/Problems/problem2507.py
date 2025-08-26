from typing import List

from .problem import Problem


class Problem2507(Problem):
    def test(self) -> bool:
        n = 15

        expected = 5

        result = self.smallestValue(n)

        print(result)

        return expected == result

    def smallestValue(self, n: int) -> int:
        next = n
        prev = 0
        while next > 0:
            i = 2
            n = next
            if prev == next:
                return prev
            prev = next
            next = 0
            limit = n / 2
            while i <= limit and n > 1:
                if n % i == 0:
                    n //= i
                    next += i
                    i = 2
                else:
                    i += 1

        return n