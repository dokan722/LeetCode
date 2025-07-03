from .problem import Problem
import math


class Problem3304(Problem):
    def test(self):
        k = 5

        expected = 'b'

        result = self.kthCharacter(k)

        print(result)

        return result == expected


    def kthCharacter(self, k):
        result = 0
        while k != 1:
            t = int(math.floor(math.log2(k)))
            if (1 << t) == k:
                t -= 1
            k -= (1 << t)
            result += 1
        return chr(ord('a') + result % 26)