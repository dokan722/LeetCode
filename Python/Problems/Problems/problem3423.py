from .problem import Problem

class Problem3423(Problem):
    def test(self):
        s = [ 1, 2, 4]
        expected = 3

        result = self.maxAdjacentDistance(s)

        print(result)

        return expected == result


    def maxAdjacentDistance(self, nums):
        maxDiff = abs(nums[len(nums) - 1] - nums[0])

        for i in range(len(nums) - 1):
            diff = abs(nums[i] - nums[i + 1])
            if (diff > maxDiff):
                maxDiff = diff

        return maxDiff