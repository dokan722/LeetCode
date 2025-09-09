from typing import List

from .problem import Problem


class Problem2798(Problem):
    def test(self) -> bool:
        hours = [5, 1, 4, 2, 2]
        target = 6

        expected = 0

        result = self.numberOfEmployeesWhoMetTarget(hours, target)

        print(result)

        return expected == result

    def numberOfEmployeesWhoMetTarget(self, hours: List[int], target: int) -> int:
        result = 0

        for hour in hours:
            if hour >= target:
                result += 1

        return result