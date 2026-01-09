import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right

class Problem865(Problem):
    def __init__(self):
        self.maxDepth = 0
        self.deepest = None

    def test(self) -> bool:
        expected = TreeNode(2, TreeNode(7), TreeNode(4))
        root = TreeNode(3, TreeNode(5, TreeNode(6), expected), TreeNode(1, TreeNode(0), TreeNode(8)))

        result = self.subtreeWithAllDeepest(root)

        return result == expected

    def subtreeWithAllDeepest(self, root: Optional[TreeNode]) -> Optional[TreeNode]:
        self.dfsDepth(root, 0)
        return self.deepest

    def dfsDepth(self, root: TreeNode, parentDepth: int) -> int:
        if root == None:
            return parentDepth
        left = self.dfsDepth(root.left, parentDepth + 1)
        right = self.dfsDepth(root.right, parentDepth + 1)
        if left == right and right >= self.maxDepth:
            self.deepest = root
            self.maxDepth = right

        return max(left, right)