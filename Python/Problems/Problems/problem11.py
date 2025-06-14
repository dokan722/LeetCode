from .problem import Problem

class Problem11(Problem):
    def test(self):
        nums = [1, 8, 6, 2, 5, 4, 8, 3, 7]

        expected = 49

        result = self.maxArea(nums)

        print(result)

        return expected == result

    def maxArea(self, height):
        maxWater = 0
        left = 0
        right = len(height) - 1
        while left < right:
            water = (right - left) * min(height[left], height[right])
            if water > maxWater:
                maxWater = water
            if height[left] < height[right]:
                left += 1
            else:
                right -= 1

        return maxWater