from .problem import Problem

class Problem1562(Problem):
    def test(self):
        nums = [3, 5, 1, 2, 4]

        m = 1

        expected = 4

        result = self.findLatestStep(nums, m)

        print(result)

        return result == expected

    def findLatestStep(self, arr, m):
        groups = [0 for _ in range(len(arr) + 2)]
        result = -1
        count = 0
        for i in range(1, len(arr) + 1):
            index = arr[i - 1]
            left = groups[index - 1]
            right = groups[index + 1]
            length = left + right + 1
            groups[index - left] = length
            groups[index + right] = length
            if left == m:
                count -= 1
            if right == m:
                count -= 1
            if length == m:
                count += 1
            if count > 0:
                result = i

        return result