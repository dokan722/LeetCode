from .problem import Problem

class Problem1855(Problem):
    def test(self):
        nums1 = [55, 30, 5, 4, 2]

        nums2 = [100, 20, 10, 10, 5]

        expected = 2

        result = self.maxDistance(nums1, nums2)

        print(result)

        return result == expected

    def maxDistance(self, nums1, nums2):
        i = 0
        j = 0

        result = 0

        while i < len(nums1) and j < len(nums2):
            if i <= j and nums1[i] <= nums2[j]:
                dist = j - i
                if dist > result:
                    result = dist
                j += 1
            elif i > j:
                j += 1
            else:
                i += 1

        return result