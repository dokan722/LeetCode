from .problem import Problem

class ListNode(object):
     def __init__(self, val=0, next=None):
         self.val = val
         self.next = next

class Problem2(Problem):
    def areSame(self, l1, l2):
        it1 = l1
        it2 = l2
        while it1 is not None and it2 is not None:
            if it1.val != it2.val:
                return False
            it1 = it1.next
            it2 = it2.next
        if it1 is not None or it2 is not None:
            return False

        return True

    def test(self):
        l1 = ListNode(2, ListNode(4, ListNode(3)))
        l2 = ListNode(5, ListNode(6, ListNode(4)))

        expected = ListNode(7, ListNode(0, ListNode(8)))
        result = self.addTwoNumbers(l1, l2)

        return self.areSame(expected, result)

    def addTwoNumbers(self, l1, l2):
        result = ListNode(0)
        currNode = result
        it1 = l1
        it2 = l2
        addNext = 0
        while it1 is not None or it2 is not None or addNext != 0:
            val1 = 0
            val2 = 0
            if it1 is not None:
                val1 = it1.val
                it1 = it1.next
            if it2 is not None:
                val2 = it2.val
                it2 = it2.next
            newValue = val1 + val2 + addNext
            if newValue >= 10:
                addNext = 1
                newValue -= 10
            else:
                addNext = 0
            newNode = ListNode(newValue)
            currNode.next = newNode
            currNode = newNode
        return result.next