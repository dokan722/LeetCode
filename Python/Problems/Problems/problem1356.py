from .problem import Problem
import numpy as np

class Problem1356(Problem):
    def test(self):
        nums = [0, 1, 2, 3, 4, 5, 6, 7, 8]

        expected = [0, 1, 2, 4, 8, 3, 5, 6, 7]

        result = self.sortByBits(nums)

        return expected == result

    def sortByBits(self, arr):
        arr.sort(key=lambda x: (self.popcount(x), x))
        return arr


    def popcount(self, x) :
        return bin(x).count('1')
