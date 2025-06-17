from .problem import Problem

class Problem3101(Problem):
    def test(self):
        nums = [0, 1, 1, 1]

        expected = 5

        result = self.countAlternatingSubarrays(nums)

        print(result)

        return result == expected

    def countAlternatingSubarrays(self, nums):
        prev = nums[0]
        running = 1
        result = 1

        for i in range(1, len(nums)):
            if nums[i] != prev:
                prev = nums[i]
                running += 1
            else:
                prev = nums[i]
                running = 1

            result += running

        return result