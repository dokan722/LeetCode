import sys

from .problem import Problem

class Problem3371(Problem):
    def test(self):
        nums = [2, 3, 5, 10]

        expected = 10

        result = self.getLargestOutlier(nums)

        return expected == result

    def getLargestOutlier(self, nums):
        sum = 0
        dic = { }
        for num in nums:
            sum += num
            if num in dic:
                dic[num] += 1
            else:
                dic[num] = 1
        result = -sys.maxsize
        for num in nums:
            if (sum - num) % 2 == 0 and ((sum - num) / 2) in dic and ((sum - num) / 2 != num or dic[num] > 1):
                if num > result:
                    result = num

        return result