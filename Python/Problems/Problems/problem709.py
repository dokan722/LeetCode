
from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem709(Problem):
    def test(self) -> bool:
        s = "Hello"

        expected = "hello"

        result = self.toLowerCase(s)

        print(result)

        return result == expected

    def toLowerCase(self, s: str) -> str:
        return s.lower()