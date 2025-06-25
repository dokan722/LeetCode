from .problem import Problem

class Problem2040(Problem):
    def test(self):
        nums1 = [-4, -2, 0, 3]

        nums2 = [2, 4]

        k = 6

        expected = 0

        result = self.kthSmallestProduct(nums1, nums2, k)

        return result == expected

    def kthSmallestProduct(self, nums1, nums2, k):
        l = len(nums1)
        left = -10000000000
        right = 10000000000
        while left <= right:
            mid = (left + right) / 2
            count = 0
            for i in range(l):
                count += self.countSmaller(nums2, nums1[i], mid)
            if count < k:
                left = mid + 1
            else:
                right = mid - 1
        return left


    def countSmaller(self, nums, f, v):
        l = len(nums)
        left = 0
        right = l - 1
        while left <= right:
            mid = (left + right) // 2
            prod = nums[mid] * f
            if (f >= 0 and prod <= v) or (f < 0 and prod > v):
                left = mid + 1
            else:
                right = mid - 1
        if f >= 0:
            return left
        return l - left
