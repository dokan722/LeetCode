from .problem import Problem

class Problem1725(Problem):
    def test(self):
        rectangles = [[5, 8], [3, 9], [5, 12], [16, 5]]

        expected = 3

        result = self.countGoodRectangles(rectangles)

        print(result)

        return result == expected

    def countGoodRectangles(self, rectangles):
        max = 0
        count = 0
        for r in rectangles:
            side = min(r[0], r[1])
            if side == max:
                count += 1
            elif side > max:
                max = side
                count = 1

        return count