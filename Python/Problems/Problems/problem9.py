from .problem import Problem

class Problem9(Problem):
    def test(self):
        n = 121

        expected = True

        result = self.isPalindrome(n)

        print(result)

        return expected == result

    def isPalindrome(self, x):
        num = str(x)
        return num[::-1] == num