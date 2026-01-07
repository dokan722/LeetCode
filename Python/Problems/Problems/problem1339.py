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

class Problem1339(Problem):
    def test(self) -> bool:
        root = TreeNode(1, TreeNode(2, TreeNode(4), TreeNode(5)), TreeNode(3, TreeNode(6)))

        expected = 110

        result = self.maxProduct(root)

        print(result)

        return result == expected

    def maxProduct(self, root: Optional[TreeNode]) -> int:
        self.sumRoots(root)

        total = root.val
        stack = []
        if root.left != None:
            stack.append(root.left)
        if root.right != None:
            stack.append(root.right)

        result = 0
        mod = 1000000007
        while stack:
            next = stack.pop()
            if next.left != None:
                stack.append(next.left)
            if next.right != None:
                stack.append(next.right)
            result = max(result, next.val * (total - next.val))

        return result % mod

    def sumRoots(self, root: Optional[TreeNode]) -> int:
        if root is None:
            return 0
        root.val += self.sumRoots(root.left) + self.sumRoots(root.right)
        return root.val