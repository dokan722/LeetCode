from .problem import Problem
import sys

class Problem3442(Problem):
    def test(self):
        s = "aaaaabbc"
        expected = 3

        result = self.maxDifference(s)

        return expected == result

    def maxDifference(self, s):
        charDic = {}
        for c in s:
            if (c in charDic):
                charDic[c] += 1
            else:
                charDic[c] = 1
        min = sys.maxsize
        max = 0
        for count in charDic.values():
            if count == 0:
                continue
            if count % 2 == 1 and count > max:
                max = count
            elif count % 2 == 0 and count < min:
                min = count

        return max - min