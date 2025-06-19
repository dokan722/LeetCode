from .problem import Problem

class Problem2294(Problem):
    def test(self):
        nums = [3, 6, 1, 2, 5]

        k = 2

        expected = 2

        result = self.partitionArray(nums, k)

        print(result)

        return result == expected

    def partitionArray(self, nums, k):
        nums.sort()
        cnt = 0
        prev = nums[0]
        result = 0
        addLast = True
        for i in range(len(nums)):
            if nums[i] != prev:
                addLast = False
                cnt += nums[i] - prev
                prev = nums[i]
                if cnt > k:
                    cnt = 0
                    result += 1
                    addLast = True

        if cnt != 0 or addLast:
            result += 1

        return result