import math
from typing import List, Dict

from .problem import Problem


class Problem941(Problem):
    def test(self) -> bool:
        arr = [0, 3, 2, 1]

        expected = True

        result = self.validMountainArray(arr)

        return expected == result

    def validMountainArray(self, arr: List[int]) -> bool:
        if len(arr) < 3 or arr[0] >= arr[1]:
            return False
        climbing = True
        for i in range(1, len(arr)):
            if climbing and arr[i] > arr[i - 1]:
                continue
            climbing = False
            if not climbing and  arr[i] < arr[i - 1]:
                continue
            return False

        return not climbing