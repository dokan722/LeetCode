#include "problem_3217.h"

#include <unordered_set>

bool problem_3217::test() {
    auto head = new ListNode(1, new ListNode(2,  new ListNode(3,  new ListNode(4, new ListNode(5)))));
    std::vector nums { 1, 2, 3 };

    auto expected = new ListNode(4, new ListNode(5));

    auto result = modifiedList(nums, head);

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

problem_3217::ListNode* problem_3217::modifiedList(std::vector<int> &nums, ListNode *head) {
    std::unordered_set<int> numsSet(nums.begin(), nums.end());
    ListNode guard(0, head);
    auto prev = &guard;
    auto curr = head;
    while (curr != nullptr)
    {
        if (numsSet.contains(curr->val))
            prev->next = curr->next;
        else
            prev = curr;
        curr = curr->next;
    }
    auto result = guard.next;
    guard.next = nullptr;
    return result;
}
