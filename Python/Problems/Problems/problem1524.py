from typing import List

from .problem import Problem


class Problem1524(Problem):
    def test(self) -> bool:
        arr = [1, 2, 3, 4, 5, 6, 7]

        expected = 16

        result = self.numOfSubarrays(arr)

        print(result)

        return result == expected

    def numOfSubarrays(self, arr: List[int]) -> int:
        n = len(arr)
        mod = 1000000007
        even = 1 if arr[0] % 2 == 0 else 0
        odd = 0 if arr[0] % 2 == 0 else 1
        result = odd

        for i in range(1, n):
            if arr[i] % 2 == 0:
                 even += 1
            else:
                tmp = odd
                odd = even + 1
                even = tmp
            result = (result + odd) % mod

        return result