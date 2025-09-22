from utils import print1DArray, print2DArray
from typing import List
from collections import Counter

from .problem import Problem


class Problem3005(Problem):
    def test(self) -> bool:
        nums = [1, 2, 2, 3, 1, 4]

        expected = 4

        result = self.maxFrequencyElements(nums)

        print(result)

        return result == expected

    def maxFrequencyElements(self, nums: List[int]) -> int:
        freq = dict()
        maxFreq = 0
        result = 0
        for num in nums:
            if num in freq:
                freq[num] += 1
            else:
                freq[num] = 1
            if freq[num] > maxFreq:
                maxFreq = freq[num]
                result = maxFreq
            elif freq[num] == maxFreq:
                result += maxFreq

        return result