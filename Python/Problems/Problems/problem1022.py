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

class Problem1022(Problem):
    def __init__(self):
        self.sum = 0

    def test(self) -> bool:
        root = TreeNode(1, TreeNode(0, TreeNode(0), TreeNode(1)), TreeNode(1, TreeNode(0), TreeNode(1)))

        expected = 22

        result = self.sumRootToLeaf(root)

        print(result)

        return result == expected

    def sumRootToLeaf(self, root: Optional[TreeNode]) -> int:
        self.sumRootToLeafRec(root, 0)
        return self.sum

    def sumRootToLeafRec(self, root: Optional[TreeNode], val: int) -> None:
        if root is None:
            return
        val = (val << 1) + root.val
        if (root.left == None and root.right == None):
            self.sum += val
            return
        self.sumRootToLeafRec(root.left, val)
        self.sumRootToLeafRec(root.right, val)