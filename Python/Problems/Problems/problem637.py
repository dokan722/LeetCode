from .problem import Problem

class TreeNode(object):
     def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right

class DepthData:
    def __init__(self, count, sum):
        self.count = count
        self.sum = sum

class Problem637(Problem):
    def test(self):
        tree = TreeNode(3, TreeNode(9), TreeNode(20, TreeNode(15), TreeNode(7)))

        expected = [3.0, 14.5, 11.0]

        result = self.averageOfLevels(tree)

        return expected == result

    def averageOfLevels(self, root):
        depthDic = {}

        self.travelTree(root, 0, depthDic)

        result = []

        for i in depthDic.values():
            result.append(float(i.sum) / i.count)

        return result

    def travelTree(self, root, depth, depthDic):
        if depth in depthDic.keys():
            depthDic[depth].count += 1
            depthDic[depth].sum += root.val
        else:
            depthDic[depth] = DepthData(1, root.val)

        if root.left is not None:
            self.travelTree(root.left, depth + 1, depthDic)
        if root.right is not None:
            self.travelTree(root.right, depth + 1, depthDic)