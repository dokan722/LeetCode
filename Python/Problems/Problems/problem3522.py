from .problem import Problem


class Problem3522(Problem):
    def test(self):
        instructions = ["jump", "add", "add", "jump", "add", "jump"]

        values = [2, 1, 3, 1, -2, -3]

        expected = 1

        result = self.calculateScore(instructions, values)

        print(result)

        return result == expected

    def calculateScore(self, instructions, values):
        i = 0
        n = len(instructions)
        visited = [False] * n
        score = 0
        while 0 <= i < n and not visited[i]:
            if (instructions[i] == "add"):
                visited[i] = True
                score += values[i]
                i += 1
            else:
                visited[i] = True
                i += values[i]

        return score