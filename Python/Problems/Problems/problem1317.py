from typing import List

from .problem import Problem


class Problem1317(Problem):
    def test(self) -> bool:
        n = 2137
        result = self.getNoZeroIntegers(n)

        return result[0] + result[1] == n

    def getNoZeroIntegers(self, n: int) -> List[int]:
        result = [0, 0]
        mult = 1
        while n > 1:
            curr = n % 10
            rest = n // 10
            if curr > 1:
                result[0] += 1 * mult
                result[1] += (curr - 1) * mult
            else:
                curr += 10
                rest -= 1
                part = curr // 2
                result[0] += part * mult
                result[1] += (curr - part) * mult

            n = rest
            mult *= 10

        if n == 1:
            result[0] += mult

        return result