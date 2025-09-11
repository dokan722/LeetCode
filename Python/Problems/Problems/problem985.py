from typing import List

from .problem import Problem


class Problem985(Problem):
    def test(self) -> bool:
        nums = [1, 2, 3, 4]
        queries = [[1, 0], [-3, 1], [-4, 0], [2, 3]]

        expected = [8, 6, 2, 4]

        result = self.sumEvenAfterQueries(nums, queries)

        return result == expected

    def sumEvenAfterQueries(self, nums: List[int], queries: List[List[int]]) -> List[int]:
        n = len(nums)
        qn = len(queries)
        evenSum = 0
        for i in range(n):
            if nums[i] % 2 == 0:
                evenSum += nums[i]

        result = [0] * qn
        for i in range(qn):
            wasEven = nums[queries[i][1]] % 2 == 0
            willBeEven = (nums[queries[i][1]] % 2 == 0) == (queries[i][0] % 2 == 0)
            newVal = nums[queries[i][1]] + queries[i][0]
            if wasEven:
                if willBeEven:
                    evenSum += queries[i][0]
                else:
                    evenSum -= nums[queries[i][1]]
            else:
                if willBeEven:
                    evenSum += newVal
            nums[queries[i][1]] = newVal
            result[i] = evenSum

        return result