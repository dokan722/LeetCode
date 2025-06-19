from .problem import Problem

class Problem1556(Problem):
    def test(self):
        n = 2137

        expected = "2.137"

        result = self.thousandSeparator(n)

        print(result)

        return result == expected

    def thousandSeparator(self, n):
        if n == 0:
            return "0"
        result = ""

        while n != 0:
            mod = n % 1000
            n -= mod

            if n != 0:
                modS = str(int(mod))
                result = "." + ("0" * (3 - len(modS))) + modS + result
                n /= 1000
            else:
                result = str(int(mod)) + result

        return result