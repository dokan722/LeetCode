from typing import List

from .problem import Problem


class Problem1577(Problem):
    def test(self) -> bool:
        nums1 = [7, 4]
        nums2 = [5, 2, 8, 9]

        expected = 1

        result = self.numTriplets(nums1, nums2)

        print(result)

        return expected == result

    def numTriplets(self, nums1: List[int], nums2: List[int]) -> int:
        counts1 = {}
        counts2 = {}
        n1 = len(nums1)
        n2 = len(nums2)
        for i in range(n1):
            if nums1[i] in counts1:
                counts1[nums1[i]] += 1
            else:
                counts1[nums1[i]] = 1
        for i in range(n2):
            if nums2[i] in counts2:
                counts2[nums2[i]] += 1
            else:
                counts2[nums2[i]] = 1

        result = 0.0

        for i in range(n1):
            num = nums1[i] * nums1[i]
            for key in counts2.keys():
                if num % key != 0:
                    continue
                req = num / key
                if req in counts2:
                    if req == key:
                        result += (counts2[key] * (counts2[req] - 1)) / 2
                    else:
                        result += (counts2[key] * counts2[req]) / 2.0

        for i in range(n2):
            num = nums2[i] * nums2[i]
            for key in counts1.keys():
                if num % key != 0:
                    continue
                req = num / key
                if req in counts1:
                    if req == key:
                        result += (counts1[key] * (counts1[req] - 1)) / 2
                    else:
                        result += (counts1[key] * counts1[req]) / 2.0

        return int(result)