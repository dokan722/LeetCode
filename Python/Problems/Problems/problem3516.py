from .problem import Problem


class Problem3516(Problem):
    def test(self) -> bool:
        x = 2
        y = 7
        z = 4

        expected = 1

        result = self.findClosest(x, y, z)

        return result == expected

    def findClosest(self, x: int, y: int, z: int) -> int:
        dist1 = abs(x - z)
        dist2 = abs(y - z)
        if dist1 == dist2:
            return 0
        return 1 if dist1 < dist2 else 2