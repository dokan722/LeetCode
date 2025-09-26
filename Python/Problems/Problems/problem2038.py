from itertools import repeat

from utils import print1DArray, print2DArray
from typing import List
from collections import Counter

from .problem import Problem


class Problem2038(Problem):
    def test(self) -> bool:
        colors = "AAABABB"

        expected = True

        result = self.winnerOfGame(colors)

        return expected == result

    def winnerOfGame(self, colors: str) -> bool:
        n = len(colors)
        aliceMoves = 0
        bobMoves = 0
        for i in range(1, n - 1):
            if colors[i - 1] == colors[i] == colors[i + 1]:
                if colors[i] == 'A':
                    aliceMoves += 1
                else:
                    bobMoves += 1

        return aliceMoves > bobMoves