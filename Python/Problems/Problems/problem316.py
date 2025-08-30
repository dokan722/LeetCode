import sys
from typing import List

from .problem import Problem


class Problem316(Problem):
    def test(self) -> bool:
        s = "bcabc"

        expected = "abc"

        result = self.removeDuplicateLetters(s)

        print(result)

        return result == expected

    def removeDuplicateLetters(self, s: str) -> str:
        n = len(s)
        indices = [sys.maxsize] * 26
        for i in range(n):
            indices[ord(s[i]) - ord('a')] = i
        stack = []
        inStack = [False] * 26

        for i in range(n):
            if inStack[ord(s[i]) - ord('a')]:
                continue

            while stack and ord(stack[-1]) > ord(s[i]) and i < indices[ord(stack[-1]) - ord('a')]:
                inStack[ord(stack[-1]) - ord('a')] = False
                stack.pop()

            inStack[ord(s[i]) - ord('a')] = True
            stack.append(s[i])


        return ''.join(stack)