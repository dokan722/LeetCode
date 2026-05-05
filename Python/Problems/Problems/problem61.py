import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

class Problem61(Problem):
    def test(self) -> bool:
        head = ListNode(1, ListNode(2, ListNode(3, ListNode(4, ListNode(5)))))
        k = 2

        expected = ListNode(4, ListNode(5, ListNode(1, ListNode(2, ListNode(3)))))

        result = self.rotateRight(head, k)

        while expected != None and result != None:
            if expected.val != result.val:
                return False
            expected = expected.next
            result = result.next

        return expected == None and result == None

    def rotateRight(self, head: Optional[ListNode], k: int) -> Optional[ListNode]:
        if head == None:
            return None
        if k == 0:
            return head
        tail = head
        n = 1
        while (tail.next != None):
            tail = tail.next
            n += 1
        k = k % n
        k = n - k - 1
        b = head
        while k > 0:
            b = b.next
            k -= 1
        tail.next = head
        nHead = b.next
        b.next = None

        return nHead