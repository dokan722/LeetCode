from .problem import Problem


class Problem2335(Problem):
    def test(self):
        amount = [1, 4, 2]

        expected = 4

        result = self.fillCups(amount)

        print(result)

        return result == expected

    def fillCups(self, amount):
        amount.sort()
        if amount[2] > amount[0] + amount[1]:
            return amount[2]

        cut = amount[1] - amount[0]
        rest = amount[0] - (amount[2] - cut) // 2
        return rest + amount[2]