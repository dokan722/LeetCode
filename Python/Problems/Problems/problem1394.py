from .problem import Problem


class Problem1394(Problem):
    def test(self):
        arr = [2, 2, 3, 4]

        expected = 2

        result = self.findLucky(arr)

        print(result)

        return result == expected

    def findLucky(self, arr):
        dic = {}

        for num in arr:
            if num in dic:
                dic[num] += 1
            else:
                dic[num] = 1
        result = -1
        for k, v in dic.items():
            if k == v and k > result:
                result = k

        return result