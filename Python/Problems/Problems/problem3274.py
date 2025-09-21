from utils import print1DArray, print2DArray
from typing import List
from collections import Counter

from .problem import Problem


class Problem3274(Problem):
    def test(self) -> bool:
        coordinate1 = "a1"
        coordinate2 = "c3"

        return self.checkTwoChessboards(coordinate1, coordinate2)

    def checkTwoChessboards(self, coordinate1: str, coordinate2: str) -> bool:
        return (ord(coordinate1[0]) % 2 == int(coordinate1[1]) % 2) == (ord(coordinate2[0]) % 2 == int(coordinate2[1]) % 2)