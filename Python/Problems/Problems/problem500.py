from typing import List

from .problem import Problem


class Problem500(Problem):
    def test(self) -> bool:
        words = ["Hello", "Alaska", "Dad", "Peace"]

        expected = ["Alaska", "Dad"]

        result = self.findWords(words)

        return result == expected

    def findWords(self, words: List[str]) -> List[str]:
        dic = {}
        for c in "qwertyuiop":
            dic[c] = 0
        for c in "asdfghjkl":
            dic[c] = 1
        for c in "zxcvbnm":
            dic[c] = 2

        result = []

        for word in words:
            eh = word.lower()
            row = dic[eh[0]]
            oneRow = True
            for c in eh[1:]:
                if dic[c] != row:
                    oneRow = False
                    break

            if oneRow:
                result.append(word)

        return result