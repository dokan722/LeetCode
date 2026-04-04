import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2075(Problem):
    def test(self) -> bool:
        encodedText = "ch   ie   pr"
        rows = 3

        expected = "cipher"

        result = self.decodeCiphertext(encodedText, rows)

        print(result)

        return result == expected

    def decodeCiphertext(self, encodedText: str, rows: int) -> str:
        if rows == 1:
            return encodedText
        result = ''
        rl = len(encodedText) // rows
        for i in range(rl):
            full = True
            col = i
            for j in range(rows):
                if col + j >= rl:
                    full = False
                    break
                result += encodedText[j * rl + j + col]
            if full == False:
                break

        m = len(result) - 1
        while m >= 0 and result[m] == ' ':
            m -= 1
        return result[0:m+1]