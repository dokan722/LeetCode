from typing import List, Any


def print1DArray(array: List[Any], valueSeparator: str = ', ') -> None:
    print(valueSeparator.join(map(str, array)), end='')

def print2DArray(array: List[List[Any]], valueSeparator: str = ', ', lineSeparator: str = '\n') -> None:
    for row in array:
        print1DArray(row, valueSeparator)
        print(lineSeparator)