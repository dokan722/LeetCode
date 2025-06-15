from .problem import Problem

class Problem12(Problem):
    def test(self):
        num = 3749

        expected = "MMMDCCXLIX"

        result = self.intToRoman(num)

        print(result)

        return expected == result

    def intToRoman(self, num):
        numString = str(num)
        result = ""

        if len(numString) == 4:
            result += 'M' * (ord(numString[0]) - ord('0'))
            numString = numString[1::]


        if len(numString) == 3:
            result = self.appendStuff(result, 'C', 'D', 'M', numString[0])
            numString = numString[1:]

        if len(numString) == 2:
            result = self.appendStuff(result, 'X', 'L', 'C', numString[0])
            numString = numString[1:]

        if len(numString) == 1:
            result = self.appendStuff(result, 'I', 'V', 'X', numString[0])
            numString = numString[1:]

        return result

    def appendStuff(self, result, one, five, dec, src):
        if ord(src) < ord('4'):
            result += one * (ord(src) - ord('0'))
        elif ord(src) == ord('4'):
            result += one + five
        elif ord(src) < ord('9'):
            result += five + one * (ord(src) - ord('0') - 5)
        else:
            result += one + dec
        return result