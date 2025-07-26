from typing import List

from .problem import Problem


class Problem1089(Problem):
    def test(self) -> bool:
        arr = [1, 0, 2, 3, 0, 4, 5, 0]

        expected = [1, 0, 0, 2, 3, 0, 0, 4]

        self.duplicateZeros(arr)

        return arr == expected




    def duplicateZeros(self, arr: List[int]) -> None:
        n = len(arr)
        result = [0] * n
        j = 0
        i = 0
        while i < n:
            if arr[j] == 0:
                result[i] = 0
                i += 1
                if i < n:
                    result[i] = 0
            else:
                result[i] = arr[j]
            j += 1
            i += 1

        arr[:] = result