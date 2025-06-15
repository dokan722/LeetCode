from .problem import Problem

class Problem1432(Problem):
    def test(self):
        num = 123456

        expected = 820000

        result = self.maxDiff(num)

        print(result)

        return expected == result

    def maxDiff(self, num):
        numsString = str(num)
        swapToMin = 0
        swapToMax = 0

        while swapToMin < len(numsString):
            if numsString[swapToMin] != '0' and numsString[swapToMin] != '1':
                break
            swapToMin += 1

        while swapToMax < len(numsString):
            if numsString[swapToMax] != '9':
                break
            swapToMax += 1

        max = numsString
        min = numsString
        if swapToMin < len(numsString):
            swapToMinC = numsString[swapToMin]
            min = min.replace(swapToMinC, ('1' if swapToMinC == numsString[0] else '0'))

        if swapToMax < len(numsString):
            swapToMaxC = numsString[swapToMax]
            max = max.replace(swapToMaxC, '9')

        return int(max) - int(min)