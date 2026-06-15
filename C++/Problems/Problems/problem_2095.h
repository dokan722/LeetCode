#ifndef PROBLEM_2095_H
#define PROBLEM_2095_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <stack>

class problem_2095 : public problem {
    struct ListNode {
        int val;
        ListNode *next;
        ListNode() : val(0), next(nullptr) {}
        ListNode(int x) : val(x), next(nullptr) {}
        ListNode(int x, ListNode *next) : val(x), next(next) {}
    };
public:
    bool test() override;

    ListNode* deleteMiddle(ListNode* head);
};

#endif //PROBLEM_2095_H
