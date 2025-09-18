from utils import print1DArray, print2DArray
from typing import List
from collections import Counter

from .problem import Problem


class Problem2108(Problem):
    def test(self) -> bool:
        words = ["abc", "car", "ada", "racecar", "cool"]

        expected = "ada"

        result = self.firstPalindrome(words)

        print(result)

        return expected == result

    def firstPalindrome(self, words: List[str]) -> str:
        for word in words:
            half = len(word) // 2
            isPal = True
            for i in range(half):
                if word[i] != word[-(i + 1)]:
                    isPal = False
                    break
            if isPal:
                return word

        return ""