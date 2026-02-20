import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2023(Problem):
    def test(self) -> bool:
        nums = ["777", "7", "77", "77"]
        target = "7777"

        expected = 4

        result = self.numOfPairs(nums, target)

        print(result)

        return result == expected

    def numOfPairs(self, nums: List[str], target: str) -> int:
        tl = len(target)
        result = 0
        parts = dict()
        for num in nums:
            l = len(num)
            if l > tl:
                continue
            if num == target[:l]:
                suf = target[l:]
                sufs =  parts[suf] if suf in parts else 0
                result += sufs
            if num == target[(tl - l):]:
                pref = target[:(tl - l)]
                prefs = parts[pref] if pref in parts else 0
                result += prefs
            if num in parts:
                parts[num] += 1
            else:
                parts[num] = 1

        return result