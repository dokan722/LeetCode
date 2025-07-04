from .problem import Problem
import math


class Problem3307(Problem):
    def test(self):
        k = 3
        operations = [1, 0]

        expected = 'a'

        result = self.kthCharacter(k, operations)

        print(result)

        return result == expected

    def kthCharacter(self, k, operations):
        swaps = 0
        while k != 1:
            t =int(math.floor(math.log2(k)))
            if (1 << t) == k:
                t -= 1
            k -= (1 << t)
            swaps += operations[t]
        return chr(ord('a') + swaps % 26)