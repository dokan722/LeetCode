#ifndef PROBLEMS_PROBLEM_61_H
#define PROBLEMS_PROBLEM_61_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>



class problem_61 : public problem {
    struct ListNode {
        int val;
        ListNode *next;
        ListNode() : val(0), next(nullptr) {}
        ListNode(int x) : val(x), next(nullptr) {}
        ListNode(int x, ListNode *next) : val(x), next(next) {}
    };

public:
    bool test() override;

    ListNode* rotateRight(ListNode* head, int k) ;
};

#endif //PROBLEMS_PROBLEM_61_H