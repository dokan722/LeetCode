from utils import print1DArray, print2DArray
from typing import List
from collections import Counter

from .problem import Problem


class Spreadsheet:
    def __init__(self, rows: int):
        self.cells = dict()

    def setCell(self, cell: str, value: int) -> None:
        self.cells[cell] = value

    def resetCell(self, cell: str) -> None:
        if cell in self.cells:
            self.cells.pop(cell)

    def getValue(self, formula: str) -> int:
        parts = formula[1:].split('+')
        return self.getCellValue(parts[0]) + self.getCellValue(parts[1])

    def getCellValue(self, cell: str) -> int:
        if cell[0].isdigit():
            return int(cell)
        if cell in self.cells:
            return self.cells[cell]
        return 0

class Problem3484(Problem):
    def test(self) -> bool:
        spreadshit = Spreadsheet(3)
        if spreadshit.getValue("=5+7") != 12:
            return False
        spreadshit.setCell("A1", 10)
        if spreadshit.getValue("=A1+6") != 16:
            return False
        spreadshit.setCell("B2", 15)
        if spreadshit.getValue("=A1+B2") != 25:
            return False
        spreadshit.resetCell("A1")
        if spreadshit.getValue("=A1+B2") != 15:
            return False

        return True