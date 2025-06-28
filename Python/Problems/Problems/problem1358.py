from .problem import Problem


class Problem1358(Problem):
    def test(self):
        s = "abcabc"
        expected = 10

        result = self.numberOfSubstrings(s)

        return expected == result

    def numberOfSubstrings(self, s):
        left = 0
        counts = [0, 0, 0]
        result = 0
        for right in range(len(s)):
            counts[ord(s[right]) - ord('a')] += 1

            while counts[0] > 0 and counts[1] > 0 and counts[2] > 0:
                result += len(s) - right
                counts[ord(s[left]) - ord('a')] -= 1
                left += 1

        return result