from utils import print1DArray, print2DArray
from typing import List
from collections import Counter

from .problem import Problem


class Problem1282(Problem):
    def test(self) -> bool:
        groupSizes = [3, 3, 3, 3, 3, 1, 3]

        expected = [[0, 1, 2], [5], [3, 4, 6]]

        result = self.groupThePeople(groupSizes)

        return expected == result

    def groupThePeople(self, groupSizes: List[int]) -> List[List[int]]:
        n = len(groupSizes)
        lists = dict()
        result = []
        for i in range(n):
            size = groupSizes[i]
            if size not in lists:
                lists[size] = []
            if len(lists[size]) == size - 1:
                lists[size].append(i)
                result.append(lists[size])
                lists.pop(size)
            else:
                lists[size].append(i)

        return result