from typing import List

from .problem import Problem

class Problem2109(Problem):
    def test(self) -> bool:
        s = "LeetcodeHelpsMeLearn"
        spaces = [8, 13, 15]

        expected = "Leetcode Helps Me Learn"

        result = self.addSpaces(s, spaces)

        print(result)

        return result == expected

    def addSpaces(self, s: str, spaces: List[int]) -> str:
        index = 0
        result = []
        for space in spaces:
            result.append(s[index:space])
            result.append(" ")
            index = space

        result.append(s[index:])
        return ''.join(result)