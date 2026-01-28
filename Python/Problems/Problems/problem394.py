import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem394(Problem):
    def test(self) -> bool:
        s = "3[a]2[bc]"

        expected = "aaabcbc"

        result = self.decodeString(s)

        print(result)

        return result == expected

    def decodeString(self, s: str) -> str:
        return self.decode(s, 0)[0]

    def decode(self, s: str, i: int) -> (str, int):
        result = ''
        phrase = ''
        nums = 0
        while i < len(s):
            if s[i].isdigit():
                nums = nums * 10 + (ord(s[i]) - ord('0'))
                i += 1
            elif s[i] == '[':
                i += 1
                phrase, i = self.decode(s, i)
                for j in range(nums):
                    result += phrase
                nums = 0
            elif s[i] == ']':
                i += 1
                return result, i
            else:
                result += s[i]
                i += 1

        return result, i
