import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem1871(Problem):
    def test(self) -> bool:
        s = "011010"
        minJump = 2
        maxJump = 3

        expected = True

        result = self.canReach(s, minJump, maxJump)

        return result == expected

    def canReach(self, s: str, minJump: int, maxJump: int) -> bool:
        n = len(s)
        if s[n - 1] == '1':
            return False
        canJump = [False] * n
        canJump[0] = True
        cur = 0
        for i in range(minJump, n):
            if canJump[i - minJump]:
                cur += 1
            if i - maxJump > 0 and canJump[i - maxJump - 1]:
                cur -= 1
            if cur > 0 and s[i] == '0':
                canJump[i] = True

        return canJump[n - 1]