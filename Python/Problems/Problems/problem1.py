from .problem import Problem

class Problem1(Problem):
    def test(self):
        nums = [2, 7, 11, 15]

        target = 9
        expected = [0, 1]
        result = self.twoSum(nums, target)

        return expected[0] == result[0] and expected[1] == result[1];

    def twoSum(self, nums, target):
        sumDic = {}
        for i in range(len(nums)):
            if target - nums[i] in sumDic:
                return [sumDic[target - nums[i]], i]
            else:
                sumDic[nums[i]] = i
        return [0, 0]