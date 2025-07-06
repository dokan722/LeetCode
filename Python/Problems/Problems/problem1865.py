from .problem import Problem


class Problem1865(Problem):
    def test(self):
        findSumPairs = FindSumPairs([1, 1, 2, 2, 2, 3], [1, 4, 5, 2, 5, 4])
        result = findSumPairs.count(7)
        if result != 8:
            return False
        findSumPairs.add(3, 2)
        result = findSumPairs.count(8)
        if result != 2:
            return False
        result = findSumPairs.count(4)
        if result != 1:
            return False
        findSumPairs.add(0, 1)
        findSumPairs.add(1, 1)
        result = findSumPairs.count(7)
        if result != 11:
            return False
        return True


class FindSumPairs(object):

    def __init__(self, nums1, nums2):
        self.nums1 = nums1
        self.nums2 = nums2
        self.numsDic = {}
        for i in range(len(nums2)):
            if nums2[i] in self.numsDic:
                self.numsDic[nums2[i]] += 1
            else:
                self.numsDic[nums2[i]] = 1

    def add(self, index, val):
        self.numsDic[self.nums2[index]] -= 1
        self.nums2[index] += val
        if self.nums2[index] in self.numsDic:
            self.numsDic[self.nums2[index]] += 1
        else:
            self.numsDic[self.nums2[index]] = 1

    def count(self, tot):
        result = 0
        for val in self.nums1:
            com = tot - val;
            if com in self.numsDic:
                result += self.numsDic[com]

        return result


