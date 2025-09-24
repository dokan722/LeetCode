from itertools import repeat

from utils import print1DArray, print2DArray
from typing import List
from collections import Counter

from .problem import Problem


class Problem166(Problem):
    def test(self) -> bool:
        numerator = 4
        denominator = 333

        expected = "0.(012)"

        result = self.fractionToDecimal(numerator, denominator)

        print(result)

        return expected == result

    def fractionToDecimal(self, numerator: int, denominator: int) -> str:
        sign = "" if numerator <= 0 and denominator < 0 or numerator >= 0 and denominator > 0 else "-"
        n = abs(numerator)
        d = abs(denominator)
        integer = str(n // d)
        n %= d
        if n == 0:
            return sign + integer
        fracBuilder = []
        numerators = dict()
        repeat = -1
        for i in range(10000):
            n *= 10
            if n in numerators:
                repeat = numerators[n]
                break

            numerators[n] = i
            digit = n // d
            fracBuilder.append(str(digit))
            n %= d
            if n == 0:
                break

        frac = ''.join(fracBuilder)
        if repeat != -1:
            frac = frac[:repeat] + "(" + frac[repeat:] + ")"

        return sign + integer + "." + frac