from .problem import Problem


class Problem3498(Problem):
    def test(self) -> bool:
        s = "abc"

        expected = 148

        result = self.reverseDegree(s)

        print(result)

        return result == expected

    def reverseDegree(self, s: str) -> int:
        result = 0

        for i in range(len(s)):
            result += (26 - (ord(s[i]) - 97)) * (i + 1)

        return result