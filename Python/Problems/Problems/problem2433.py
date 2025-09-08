from typing import List

from .problem import Problem


class Problem2433(Problem):
    def test(self) -> bool:
        pref = [5, 2, 0, 3, 1]

        expected = [5, 7, 2, 3, 2]

        result = self.findArray(pref)

        return result == expected

    def findArray(self, pref: List[int]) -> List[int]:
        prev = pref[0]
        for i in range(1, len(pref)):
            tmp = pref[i]
            pref[i] = prev ^ pref[i]
            prev = tmp

        return pref