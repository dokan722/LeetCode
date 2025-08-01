import math
from typing import List, Dict

from .problem import Problem


class Problem3248(Problem):
    def test(self) -> bool:
        n = 2
        commands = ["RIGHT", "DOWN"]

        expected = 3

        result = self.finalPositionOfSnake(n, commands)

        print(result)

        return result == expected

    def finalPositionOfSnake(self, n: int, commands: List[str]) -> int:
        x = 0
        y = 0
        for command in commands:
            if command == "RIGHT":
                y += 1
            elif command == "LEFT":
                y -= 1
            elif command == "UP":
                x -= 1
            else:
                x += 1


        return x * n + y