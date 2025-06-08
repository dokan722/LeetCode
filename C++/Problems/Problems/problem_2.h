#ifndef PROBLEM_2_H
#define PROBLEM_2_H
#include "../problem.h"

struct ListNode {
    int val;
    ListNode *next;
    ListNode() : val(0), next(nullptr) {}
    ListNode(int x) : val(x), next(nullptr) {}
    ListNode(int x, ListNode *next) : val(x), next(next) {}
    ~ListNode() { delete next; }
};

class problem_2 : public problem
{
public:
    bool test() override;

    ListNode* addTwoNumbers(const ListNode* l1, const ListNode* l2);
private:
    bool areSame(ListNode *l1, ListNode *l2);
};



#endif //PROBLEM_2_H
