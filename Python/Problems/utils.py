from typing import List


def print1DArray(array: List[int], valueSeparator: str = ', ') -> None:
    print(valueSeparator.join(map(str, array)), end='')

def print2DArray(array: List[List[int]], valueSeparator: str = ', ', lineSeparator: str = ', ') -> None:
    for row in array:
        print1DArray(row, valueSeparator)
        print(lineSeparator.join(map(str, row)), end='')