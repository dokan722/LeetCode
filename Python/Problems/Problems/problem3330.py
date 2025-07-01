from .problem import Problem


class Problem3330(Problem):
    def test(self):
        word = "abbcccc"

        expected = 5

        result = self.possibleStringCount(word)

        print(result)

        return result == expected

    def possibleStringCount(self, word):
        l = 1
        prev = word[0]
        result = 1
        for i in range(1, len(word)):
            if prev != word[i]:
                result += (l - 1)
                l = 1
                prev = word[i]
            else:
                l += 1

        result += (l - 1)

        return result