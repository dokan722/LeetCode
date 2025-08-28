from typing import List

from .problem import Problem


class Problem1894(Problem):
    def test(self) -> bool:
        chalk = [3, 4, 1, 2]
        k = 25

        expected = 1

        result = self.chalkReplacer(chalk, k)

        print(result)

        return result == expected

    def chalkReplacer(self, chalk: List[int], k: int) -> int:
        sum = 0
        for i in range(len(chalk)):
            sum += chalk[i]
        rest = k % sum
        child = 0
        while chalk[child] <= rest:
            rest -= chalk[child]
            child += 1

        return child