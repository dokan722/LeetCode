from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1929(Problem):
    def test(self) -> bool:
        nums = [1, 3, 2, 1]

        expected = [1, 3, 2, 1, 1, 3, 2, 1]

        result = self.getConcatenation(nums)

        print1DArray(result)

        return result == expected

    def getConcatenation(self, nums: List[int]) -> List[int]:
        return 2 * nums