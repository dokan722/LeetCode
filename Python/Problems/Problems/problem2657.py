import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2657(Problem):
    def test(self) -> bool:
        A = [1, 3, 2, 4]
        B = [3, 1, 2, 4]

        expected = [0, 2, 3, 4]

        result = self.findThePrefixCommonArray(A, B)

        print1DArray(result)

        return result == expected

    def findThePrefixCommonArray(self, A: List[int], B: List[int]) -> List[int]:
        n = len(A)
        curr = 0
        result = [0] * n
        setA = set()
        setB = set()
        for i in range(n):
            if A[i] == B[i]:
                curr += 1
            else:
                if B[i] in setA:
                    curr += 1
                if A[i] in setB:
                    curr += 1
                setA.add(A[i])
                setB.add(B[i])
            result[i] = curr

        return result