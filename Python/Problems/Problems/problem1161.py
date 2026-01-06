import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class TreeNode:
     def __init__(self, val=0, left=None, right=None):
         self.val = val
         self.left = left
         self.right = right

class Problem1161(Problem):
    def test(self) -> bool:
        root = TreeNode(1, TreeNode(7, TreeNode(7), TreeNode(-8)), TreeNode(0))

        expected = 2

        result = self.maxLevelSum(root)

        print(result)

        return result == expected

    def maxLevelSum(self, root: Optional[TreeNode]) -> int:
        result = 1
        maxSum = root.val
        level = 0
        nodes = [root]
        while nodes:
            currSum = 0
            level += 1
            curr = len(nodes)
            for _ in range(curr):
                next = nodes.pop(0)
                currSum += next.val
                if next.left != None:
                    nodes.append(next.left)
                if next.right != None:
                    nodes.append(next.right)

            if currSum > maxSum:
                result = level
                maxSum = currSum
        return result
