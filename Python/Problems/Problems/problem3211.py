from itertools import repeat

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3211(Problem):
    def test(self) -> bool:
        n = 3

        expected = 5

        result = self.validStrings(n)

        return expected == len(result)

    def validStrings(self, n: int) -> List[str]:
        result = [ '0', '1' ]
        for i in range(1, n):
            newResult = []
            for s in result:
                newResult.append(s + "1")
                if s[-1] == '1':
                    newResult.append(s + "0")

            result = newResult

        return result