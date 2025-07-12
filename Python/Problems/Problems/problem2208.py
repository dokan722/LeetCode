import heapq

from .problem import Problem


class Problem2208(Problem):
    def test(self):
        nums = [32,98,23,14,67,40,26,9,96,96,91,76,4,40,42,2,31,13,16,37,62,2,27,25,100,94,14,3,48,56,64,59,33,10,74,47,73,72,89,69,15,79,22,18,53,62,20,9,76,64]

        expected = 3

        result = self.halveArray(nums)

        return expected == result

    def halveArray(self, nums):
        initialSum = 0.0
        queue = []

        for num in nums:
            initialSum += num
            heapq.heappush(queue, -num)

        result = 0
        sum = initialSum
        while sum > initialSum / 2.0:
            max = -heapq.heappop(queue)
            max /= 2.0
            sum -= max
            heapq.heappush(queue, -max)
            result += 1

        return result