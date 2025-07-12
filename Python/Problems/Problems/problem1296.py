from .problem import Problem


class Problem1296(Problem):
    def test(self):
        nums = [3, 2, 1, 2, 3, 4, 3, 4, 5, 9, 10, 11]
        k = 3

        expected = True

        result = self.isPossibleDivide(nums, k)

        return expected == result

    def isPossibleDivide(self, nums, k):
        n = len(nums)
        if n % k != 0:
            return False
        freq = {}
        for num in nums:
            if (num in freq):
                freq[num] += 1
            else:
                freq[num] = 1
        sorted = list(freq.keys())
        sorted.sort()

        for key in sorted:
            f = freq[key]
            if f == 0:
                continue

            for i in range(k):
                next = key + i
                if next not in freq or freq[next] < f:
                    return False
                freq[next] -= f


        return True