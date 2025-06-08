from .problem import Problem

class Problem386(Problem):
    def test(self):
        n = 13

        expected = [1, 10, 11, 12, 13, 2, 3, 4, 5, 6, 7, 8, 9]

        result = self.lexicalOrder(n)

        return expected == result

    def lexicalOrder(self, n):
        result = []

        self.lexicalOrderRec(n, 1, result)
        return result

    def lexicalOrderRec(self, n, num, result):
        if num > n:
            return

        result.append(num)
        self.lexicalOrderRec(n, num * 10, result)

        if num % 10 != 9:
            self.lexicalOrderRec(n, num + 1, result)
