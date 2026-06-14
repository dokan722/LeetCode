#ifndef PROBLEM_2130_H
#define PROBLEM_2130_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <stack>

struct ListNode {
    int val;
    ListNode *next;
    ListNode() : val(0), next(nullptr) {}
    ListNode(int x) : val(x), next(nullptr) {}
    ListNode(int x, ListNode *next) : val(x), next(next) {}
};

class problem_2130 : public problem {
public:
    bool test() override;

    int pairSum(ListNode* head);
};

#endif //PROBLEM_2130_H
