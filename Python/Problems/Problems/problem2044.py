from typing import List, Dict

from .problem import Problem


class Problem2044(Problem):
    def test(self) -> bool:
        nums = [3, 2, 1, 5]

        expected = 6

        result = self.countMaxOrSubsets(nums)

        print(result)

        return expected == result

    def countMaxOrSubsets(self, nums: List[int]) -> int:
        counts = {}

        self.testSubset(0, 0, nums, counts)

        result = 0
        for value in counts.values():
            if value > result:
                result = value


        return result

    def testSubset(self, num: int, id: int, nums: List[int], counts: Dict[int, int]) -> None:
        if id >= len(nums):
            return
        self.testSubset(num, id + 1, nums, counts)
        num = num | nums[id]
        if num not in counts:
            counts[num] = 1
        else:
            counts[num] += 1

        self.testSubset(num, id + 1, nums, counts)