import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem948(Problem):
    def test(self) -> bool:
        tokens = [100, 200, 300, 400]
        power = 200

        expected = 2

        result = self.bagOfTokensScore(tokens, power)

        print(result)

        return result == expected

    def bagOfTokensScore(self, tokens: List[int], power: int) -> int:
        n = len(tokens)
        tokens.sort()
        l = 0
        r = n - 1
        score = 0
        while l < r:
            if tokens[l] <= power:
                score += 1
                power -= tokens[l]
                l += 1
            elif score > 0:
                score -= 1
                power += tokens[r]
                r -= 1
            else:
                break
        if l == r and tokens[l] <= power:
            score += 1
        return score