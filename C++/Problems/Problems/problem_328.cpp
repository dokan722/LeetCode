#include "problem_328.h"

bool problem_328::test() {
    auto head = new ListNode(1, new ListNode(2,  new ListNode(3,  new ListNode(4, new ListNode(5)))));

    auto expected = new ListNode(1, new ListNode(3,  new ListNode(5,  new ListNode(2, new ListNode(4)))));

    auto result = oddEvenList(head);

    auto resultPtr = result;
    auto expectedPtr = expected;
    while (resultPtr != nullptr && expectedPtr != nullptr)
    {
        if (resultPtr->val != expectedPtr->val)
            return false;
        resultPtr = resultPtr->next;
        expectedPtr = expectedPtr->next;
    }
    if (resultPtr != nullptr || expectedPtr != nullptr)
        return false;
    delete head;
    delete expected;
    return true;
}

problem_328::ListNode* problem_328::oddEvenList(ListNode *head) {
    auto even = ListNode();
    auto odd = ListNode();
    auto currEven = &even;
    auto currOdd = &odd;
    auto curr = head;
    int cnt = 1;
    while (curr != nullptr)
    {
        if (cnt % 2 == 0)
        {
            currEven->next = curr;
            currEven = currEven->next;
        }
        else
        {
            currOdd->next = curr;
            currOdd = currOdd->next;
        }
        curr = curr->next;
        cnt++;
    }

    currEven->next = nullptr;
    currOdd->next = even.next;
    auto result = odd.next;
    odd.next = nullptr;
    even.next = nullptr;
    return result;
}
