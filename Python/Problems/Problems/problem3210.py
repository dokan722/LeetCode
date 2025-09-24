from itertools import repeat

from utils import print1DArray, print2DArray
from typing import List
from collections import Counter

from .problem import Problem


class Problem3210(Problem):
    def test(self) -> bool:
        s = "dart"
        k = 3

        expected = "tdar"

        result = self.getEncryptedString(s, k)

        print(result)

        return result == expected

    def getEncryptedString(self, s: str, k: int) -> str:
        n = len(s)
        shift = (k % n)
        return s[shift:] + s[:shift]