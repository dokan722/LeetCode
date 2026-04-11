import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1138(Problem):
    def test(self) -> bool:
        target = "leet"

        expected = "DDR!UURRR!!DDD!"

        result = self.alphabetBoardPath(target)

        print(result)

        return result == expected

    def alphabetBoardPath(self, target: str) -> str:
        x = 0
        y = 0
        result = ''
        for c in target:
            ti = ord(c) - ord('a')
            xt = ti // 5
            yt = ti % 5
            mv = x - xt
            mh = y - yt
            vertical = ''
            horizontal = ''
            if mv > 0:
                vertical = 'U' * mv
            elif mv < 0:
                vertical = 'D' * abs(mv)
            if mh > 0:
                horizontal = 'L' * mh
            elif mh < 0:
                horizontal = 'R' * abs(mh)
            if xt == 5:
                result += horizontal + vertical
            else:
                result += vertical + horizontal
            result += '!'
            x = xt
            y = yt

        return result