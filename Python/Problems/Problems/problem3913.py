import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem3913(Problem):
    def test(self) -> bool:
        s = "leetcode"

        expected = "leetcedo"

        result = self.sortVowels(s)

        print(result)

        return result == expected

    def sortVowels(self, s: str) -> str:
        n = len(s)
        vowels = ['a', 'e', 'i', 'o', 'u']
        first = [-1] * 5
        counts = [0] * 5
        for i in range(n):
            for j in range(5):
                if s[i] == vowels[j]:
                    if first[j] == -1:
                        first[j] = i
                    counts[j] += 1
        ids = [0, 1, 2, 3, 4]
        ids.sort(key=lambda x: (-counts[x], first[x]))
        cur = 0
        result = []
        for i in range(n):
            vowel = False
            for j in range(5):
                if s[i] == vowels[j]:
                    vowel = True
                    break
            if vowel:
                while counts[ids[cur]] == 0:
                    cur += 1
                result.append(vowels[ids[cur]])
                counts[ids[cur]] -= 1
            else:
                result.append(s[i])
        return ''.join(result)