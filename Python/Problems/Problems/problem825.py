from typing import List

from .problem import Problem


class Problem825(Problem):
    def test(self) -> bool:
        ages = [20, 30, 100, 110, 120]
        expected = 3

        result = self.numFriendRequests(ages)

        print(result)

        return result == expected

    def numFriendRequests(self, ages: List[int]) -> int:
        counts = [0] * 121
        for age in ages:
            counts[age] += 1

        result = 0
        for i in range(1, 121):
            x = 0.5 * i + 7
            minAge = x.__ceil__()
            start = minAge + 1 if minAge == x else minAge
            maxAge = i
            for j in range(start, maxAge):
                result += counts[j] * counts[i]
            if i >= start:
                result += max(counts[i] * (counts[i] - 1), 0)

        return result