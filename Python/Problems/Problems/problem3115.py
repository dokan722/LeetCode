from typing import List

from .problem import Problem


class Problem3115(Problem):
    def test(self) -> bool:
        nums = [4, 2, 9, 5, 3]

        expected = 3

        result = self.maximumPrimeDifference(nums)

        print(result)

        return expected == result

    def maximumPrimeDifference(self, nums: List[int]) -> int:
        n = len(nums)
        possiblePrimeDivisors = [2, 3, 5, 7]
        first = -1
        last = 0
        for i in range(n):
            isPrime = True
            for prime in possiblePrimeDivisors:
                if nums[i] == 1 or (nums[i] % prime == 0 and nums[i] // prime != 1):
                    isPrime = False
                    break
            if isPrime:
                if first == -1:
                    first = i
                last = i

        return last - first