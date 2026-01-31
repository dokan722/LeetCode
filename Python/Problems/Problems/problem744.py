import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem744(Problem):
    def test(self) -> bool:
        letters = ['c', 'f', 'j']
        target = 'c'

        expected = 'f'

        result = self.nextGreatestLetter(letters, target)

        print(result)

        return result == expected

    def nextGreatestLetter(self, letters: List[str], target: str) -> str:
        left = 0
        right = len(letters) - 1
        if letters[right] <= target:
            return letters[0]
        while left < right:
            mid = (left + right) // 2
            if letters[mid] <= target:
                left = mid + 1
            else:
                right = mid

        return letters[left]