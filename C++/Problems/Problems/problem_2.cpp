#include "problem_2.h"

bool problem_2::test() {
    auto l1 =  ListNode(2,  new ListNode(4,  new ListNode(3)));
    auto l2 =  ListNode(5,  new ListNode(6,  new ListNode(4)));

    auto expected = new ListNode(7, new ListNode(0, new ListNode(8))); ;

    auto result = addTwoNumbers(&l1, &l2);

    return areSame(expected, result);
}

ListNode * problem_2::addTwoNumbers(const ListNode *l1, const ListNode *l2) {
    auto result =  ListNode(0);
    auto currNode = &result;
    auto it1 = l1;
    auto it2 = l2;
    auto addNext = 0;
    while (it1 != nullptr || it2 != nullptr || addNext != 0)
    {
        auto val1 = 0;
        auto val2 = 0;
        if (it1 != nullptr)
        {
            val1 = it1->val;
            it1 = it1->next;
        }
        if (it2 != nullptr)
        {
            val2 = it2->val;
            it2 = it2->next;
        }
        auto newValue = val1 + val2 + addNext;
        if (newValue >= 10)
        {
            addNext = 1;
            newValue -= 10;
        }
        else
            addNext = 0;
        auto newNode = new ListNode(newValue);
        currNode->next = newNode;
        currNode = newNode;

    }
    auto root = result.next;
    result.next = nullptr;
    return root;
}

bool problem_2::areSame(ListNode *l1, ListNode *l2) {
    auto it1 = l1;
    auto it2 = l2;
    while (it1 != nullptr && it2 != nullptr)
    {
        if (it1->val != it2->val)
            return false;
        it1 = it1->next;
        it2 = it2->next;
    }
    if (it1 != nullptr || it2 != nullptr)
        return false;

    return true;
}


