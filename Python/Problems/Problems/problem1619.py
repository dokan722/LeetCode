from typing import List, Dict

from .problem import Problem


class Problem1619(Problem):
    def test(self) -> bool:
        arr = [1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3]

        expected = 2.0

        result = self.trimMean(arr)

        print(result)

        return result == expected

    def trimMean(self, arr: List[int]) -> float:
        arr.sort()
        n = len(arr)
        outliners = n // 20

        sum = 0
        for i in range(outliners, n - outliners):
            sum += arr[i]

        return sum / (n - 2 * outliners)