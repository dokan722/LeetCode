import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2469(Problem):
    def test(self) -> bool:
        celsius = 36.50

        expected = [309.65000, 97.70000]

        result = self.convertTemperature(celsius)

        print(result)

        return result == expected

    def convertTemperature(self, celsius: float) -> List[float]:
        return [celsius + 273.15, celsius * 1.8 + 32]