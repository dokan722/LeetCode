import math
from typing import List

from .problem import Problem


class Problem1775(Problem):
    def test(self) -> bool:
        nums1 = [1, 2, 3, 4, 5, 6]
        nums2 = [1, 1, 2, 2, 2, 2]

        expected = 3

        result = self.minOperations(nums1, nums2)

        print(result)

        return expected == result

    def minOperations(self, nums1: List[int], nums2: List[int]) -> int:
        ns = [len(nums1), len(nums2)]
        sums = [0, 0]
        counts = [[0] * 7, [0] * 7]
        for i in range(ns[0]):
            sums[0] += nums1[i]
            counts[0][nums1[i]] += 1
        for i in range(ns[1]):
            sums[1] += nums2[i]
            counts[1][nums2[i]] += 1

        longer = 0 if ns[0] > ns[1] else 1
        shorter = (longer + 1) % 2
        bigger = 0 if sums[0] > sums[1] else 1
        smaller = (bigger + 1) % 2

        if ns[longer] > ns[shorter] * 6:
            return -1

        ops = 0
        for i in range(1, 6):
            diff = sums[bigger] - sums[smaller]
            currentChange = 6 - i
            if (counts[smaller][i] + counts[bigger][7 - i]) * currentChange >= diff:
                ops += math.ceil(diff / currentChange)
                break

            ops += counts[smaller][i]
            ops += counts[bigger][7 - i]
            sums[smaller] += counts[smaller][i] * currentChange
            sums[bigger] -= counts[bigger][7 - i] * currentChange

        return ops