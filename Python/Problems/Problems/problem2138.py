from .problem import Problem

class Problem2138(Problem):
    def test(self):
        s = "abcdefghi"
        k = 3
        fill = 'x'

        expected = ["abc", "def", "ghi"]

        result = self.divideString(s, k, fill)

        return result == expected

    def divideString(self, s, k, fill):
        result = []
        rest = len(s) % k
        if rest != 0:
            s = s + (fill * (k - rest))
        for i in range(0, len(s), k):
            result.append(s[i:i+k])

        return result