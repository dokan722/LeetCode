from typing import List, Dict

from .problem import Problem


class Problem3039(Problem):
    def test(self) -> bool:
        s = "aabcbbca"

        expected = "ba"

        result = self.lastNonEmptyString(s)

        print(result)

        return expected == result

    def lastNonEmptyString(self, s: str) -> str:
        counts = [0] * 26
        lastIds = [0] * 26
        for i in range(len(s)):
            counts[ord(s[i]) - ord('a')] += 1
            lastIds[ord(s[i]) - ord('a')] = i

        maxCount = 0
        for count in counts:
            if count > maxCount:
                maxCount = count

        remainingLetters = []
        for i in range(26):
            if counts[i] == maxCount:
                remainingLetters.append((lastIds[i], chr(i + ord('a'))))
        result = ''
        remainingLetters.sort()
        for letter in remainingLetters:
            result += letter[1]

        return result