import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2895(Problem):
    def test(self) -> bool:
        processorTime = [10, 20]
        tasks = [2, 3, 1, 2, 5, 8, 4, 3]

        expected = 23

        result = self.minProcessingTime(processorTime, tasks)

        print(result)

        return result == expected

    def minProcessingTime(self, processorTime: List[int], tasks: List[int]) -> int:
        n = len(processorTime)
        processorTime.sort()
        tasks.sort()
        result = 0
        for i in range(n):
            result = max(result, processorTime[i] + tasks[4 * (n - i) - 1]);

        return result