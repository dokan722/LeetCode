from .problem import Problem

class Problem1545(Problem):
    def test(self):
        n = 3

        k = 7

        expected = '1'

        result = self.findKthBit(n, k)

        print(result)

        return expected == result

    def findKthBit(self, n, k):
        if n == 1:
            return '0'

        sLen = 1 << n
        half = sLen / 2

        if k < half:
            return self.findKthBit(n - 1, k)

        if k == sLen / 2:
            return '1'

        return '0' if self.findKthBit(n - 1, sLen - k) == '1' else '1'