from utils import print1DArray, print2DArray
from typing import List
from collections import Counter

from .problem import Problem


class Problem165(Problem):
    def test(self) -> bool:
        version1 = "1.2"
        version2 = "1.10"

        expected = -1

        result = self.compareVersion(version1, version2)

        print(result)

        return expected == result

    def compareVersion(self, version1: str, version2: str) -> int:
        splitted = [version1.split('.'), version2.split('.')]
        longer = 0 if len(splitted[0]) > len(splitted[1]) else  1
        shorter = (longer + 1) % 2
        for i in range(len(splitted[shorter])):
            if int(splitted[0][i]) > int(splitted[1][i]):
                return 1
            if int(splitted[0][i]) < int(splitted[1][i]):
                return -1

        for i in range(len(splitted[shorter]), len(splitted[longer])):
            if int(splitted[longer][i]) != 0:
                return -1 if longer == 1 else 1

        return 0