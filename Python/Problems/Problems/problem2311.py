from .problem import Problem

class Problem2311(Problem):
    def test(self):
        s = "1001010"

        k = 5

        expected = 5

        result = self.longestSubsequence(s, k);

        return result == expected

    def longestSubsequence(self, s, k):
        factor = 1
        num = 0
        i = len(s) - 1
        found = False
        lastOne = len(s)
        while i >= 0:
            if s[i] == '1':
                if num + factor <= k:
                    num += factor
                    lastOne = i
                    found = True
                else:
                    break
            if factor > 10 ** 10:
                break
            factor *= 2
            i -= 1
        if i == -1:
            return len(s)
        zeros = 0
        if not found:
            for v in s:
                if v == '0':
                    zeros += 1
            return zeros
        for v in s[:lastOne]:
            if v == '0':
                zeros += 1

        return len(s) - lastOne + zeros