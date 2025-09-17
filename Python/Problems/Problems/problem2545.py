from utils import print1DArray, print2DArray
from typing import List
from collections import Counter

from .problem import Problem


class Problem2545(Problem):
    def test(self) -> bool:
        score = [[10, 6, 9, 1], [7, 5, 11, 2], [4, 8, 3, 15]]
        k = 2

        expected = [[7, 5, 11, 2], [10, 6, 9, 1], [4, 8, 3, 15]]

        result = self.sortTheStudents(score, k)

        print2DArray(result)

        return result == expected

    def sortTheStudents(self, score: List[List[int]], k: int) -> List[List[int]]:
        score.sort(key=lambda x: -x[k])
        return score