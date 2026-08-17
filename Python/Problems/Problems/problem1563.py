import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem1563(Problem):
    def test(self) -> bool:
        stoneValue = [6, 2, 3, 4, 5, 5]

        expected = 18

        result = self.stoneGameV(stoneValue)

        print(result)

        return result == expected

    def stoneGameV(self, stoneValue: List[int]) -> int:
        n = len(stoneValue)
        dp = [[-1 for _ in range(n)] for _ in range(n)]
        pref = [0]
        for i in range(n):
            pref.append(pref[i] + stoneValue[i])
        return self.gameDp(dp, pref, stoneValue, 0, n - 1)

    def gameDp(self, dp: List[List[int]], pref: List[int], arr: List[int], l: int, r: int) -> int:
        if l == r:
            return 0
        if dp[l][r]!= -1:
            return dp[l][r]
        total = pref[r + 1] - pref[l]
        pre = 0
        best = 0
        for i in range(l, r):
            pre += arr[i]
            suf = total - pre
            if pre > suf:
                best = max(best, suf + self.gameDp(dp, pref, arr, i + 1, r))
            elif pre < suf:
                best = max(best, pre + self.gameDp(dp, pref, arr, l, i))
            else:
                best = max(best, max(pre + self.gameDp(dp, pref, arr, l, i), suf + self.gameDp(dp, pref, arr, i + 1, r)))
        dp[l][r] = best
        return best
