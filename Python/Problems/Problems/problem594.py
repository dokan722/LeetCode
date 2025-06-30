from .problem import Problem


class Problem594(Problem):
    def test(self):
        nums = [1, 3, 2, 2, 5, 2, 3, 7]

        expected = 5

        result = self.findLHS(nums)

        print(result)

        return result == expected

    def findLHS(self, nums):
        nums.sort()
        result = 0
        count = 1
        prevCount = 0
        prev = nums[0]
        for i in range(1, len(nums)):
            if nums[i] == prev:
                count += 1
            else:
                if prevCount != 0 and count + prevCount > result:
                    result = count + prevCount;
                if nums[i] - 1 != prev:
                    prevCount = 0
                else:
                    prevCount = count
                count = 1
                prev = nums[i]

        if prevCount != 0 and count + prevCount > result:
            result = count + prevCount

        return result