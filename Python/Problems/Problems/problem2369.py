from .problem import Problem


class Problem2369(Problem):
    def test(self):
        nums = [4, 4, 4, 5, 6]

        expected = True

        result = self.validPartition(nums)

        return result == expected

    def validPartition(self, nums):
        n = len(nums)
        check = [0]
        visited = [False] * n
        check.append(0)
        while len(check) > 0:
            popped = check.pop()
            if visited[popped]:
                continue
            if self.checkTwo(nums, popped):
                ch = popped + 2
                if ch == n:
                    return True
                check.append(ch)
            if self.checkThree(nums, popped):
                ch = popped + 3
                if ch == n:
                    return True
                check.append(ch)

            visited[popped] = True

        return False

    def checkTwo(self, nums, index):
        if index + 1 >= len(nums):
                return False
        if nums[index] == nums[index + 1]:
            return True

        return False

    def checkThree(self, nums, index):
        if index + 2 >= len(nums):
                return False
        if nums[index] == nums[index + 1] == nums[index + 2]:
            return True
        if nums[index] == nums[index + 1] - 1 == nums[index + 2] - 2:
            return True

        return False