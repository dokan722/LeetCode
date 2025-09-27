from itertools import repeat

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1593(Problem):
    def test(self) -> bool:
        s = "ababccc"

        expected = 5

        result = self.maxUniqueSplit(s)

        print(result)

        return expected == result

    def maxUniqueSplit(self, s: str) -> int:
        return self.splitFurther(s, "", 0, set())

    def splitFurther(self, s: str, curr: str, index: int, present: Set[int]) -> int:
        if index >= len(s):
            if curr == '':
                return len(present)
            if curr in present:
                return -1
            return len(present) + 1

        curr += s[index]
        withInsert = -1
        if curr not in present:
            present.add(curr)
            withInsert = self.splitFurther(s, '', index + 1, present)
            present.remove(curr)

        noInsert = self.splitFurther(s, curr, index + 1, present)

        return max(withInsert, noInsert)