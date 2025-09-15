from utils import print1DArray, print2DArray
from typing import List
from collections import Counter

from .problem import Problem


class Problem1935(Problem):
    def test(self) -> bool:
        text = "hello world"
        brokenLetters = "ad"

        expected = 1

        result = self.canBeTypedWords(text, brokenLetters)

        print(result)

        return result == expected

    def canBeTypedWords(self, text: str, brokenLetters: str) -> int:
        lettersSet = set()
        for letter in brokenLetters:
            lettersSet.add(letter)

        words = 1
        brokenWords = 0
        canWrite = True
        for c in text:
            if c == ' ':
                words += 1
                canWrite = True
                continue
            if canWrite and c in lettersSet:
                brokenWords += 1
                canWrite = False

        return words - brokenWords