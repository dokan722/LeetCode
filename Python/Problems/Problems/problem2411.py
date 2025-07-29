from typing import List, Dict

from .problem import Problem


class Problem2411(Problem):
    def test(self) -> bool:
        nums = [1, 0, 2, 1, 3]

        expected = [3, 3, 2, 2, 1]

        result = self.smallestSubarrays(nums)

        return result == expected

    def smallestSubarrays(self, nums: List[int]) -> List[int]:
        n = len(nums)
        lastChange = [0] * 32
        result = [0] * n
        for i in range(n - 1, -1, -1):
            last = i
            bits = self.intToBit(nums[i])
            for j in range(32):
                if bits[j] == 0:
                    if lastChange[j] != -1:
                        last = max(last, lastChange[j])
                else:
                    lastChange[j] = i
                result[i] = last - i + 1

        return result

    def intToBit(self, value: int) -> List[int]:
        bits = [0] * 32

        for i in range(32):
            bits[31 - i] = (value >> i) & 1

        return bits