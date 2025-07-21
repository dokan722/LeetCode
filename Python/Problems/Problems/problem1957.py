from .problem import Problem


class Problem1957(Problem):
    def test(self) -> bool:
        s = "leeetcode"

        expected = "leetcode"

        result = self.makeFancyString(s)

        print(result)

        return result == expected

    def makeFancyString(self, s: str) -> str:
        result = [s[0]]

        count = 1
        for i in range(1, len(s)):
            if s[i] == s[i - 1]:
                count += 1
            else:
                count = 1
            if count < 3:
                result.append(s[i])


        return ''.join(result)