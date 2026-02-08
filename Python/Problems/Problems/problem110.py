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

class Problem110(Problem):
    def test(self) -> bool:
        root = TreeNode(3, TreeNode(9), TreeNode(20, TreeNode(15), TreeNode(7)))

        expected = True

        result = self.isBalanced(root)

        return result == expected

    def isBalanced(self, root: Optional[TreeNode]) -> bool:
        return self.isBalancedRec(root) != -1

    def isBalancedRec(self, root: Optional[TreeNode]) -> int:
        if root == None:
            return 0

        left = self.isBalancedRec(root.left)
        if left == -1:
            return -1
        right = self.isBalancedRec(root.right)
        if right == -1:
            return -1
        if abs(left - right) > 1:
            return -1
        return max(left, right) + 1