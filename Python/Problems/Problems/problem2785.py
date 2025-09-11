from typing import List

from .problem import Problem


class Problem2785(Problem):
    def test(self) -> bool:
        s = "lEetcOde"

        expected = "lEOtcede"

        result = self.sortVowels(s)

        print(result)

        return result == expected

    def sortVowels(self, s: str) -> str:
        vowelsDic = {
            'A': 0,
            'E': 0,
            'I': 0,
            'O': 0,
            'U': 0,
            'a': 0,
            'e': 0,
            'i': 0,
            'o': 0,
            'u': 0,
        }
        for c in s:
            if self.isVowel(c):
                vowelsDic[c] += 1

        p = 0
        result = list(s)
        for value, count in vowelsDic.items():
            for i in range(count):
                while not self.isVowel(s[p]):
                    p += 1
                result[p] = value
                p += 1

        return ''.join(result)

    def isVowel(self, s: chr) -> bool:
        c = s.lower()
        if c == 'a' or c == 'e' or c == 'i' or c == 'o' or c == 'u':
            return True
        return False