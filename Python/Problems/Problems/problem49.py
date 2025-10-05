import heapq
from itertools import repeat

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem49(Problem):
    def test(self) -> bool:
        strs = ["eat", "tea", "tan", "ate", "nat", "bat"]

        expected = [["eat", "tea", "ate"], ["tan", "nat"], ["bat"]]

        result = self.groupAnagrams(strs)

        print2DArray(result)

        return result == expected

    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        result = dict()
        for s in strs:
            arr = list(s)
            arr.sort()
            key = ''.join(arr)
            if key in result:
                result[key].append(s)
            else:
                result[key] = [ s ]

        return list(result.values())