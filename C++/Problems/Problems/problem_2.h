#ifndef PROBLEM_2_H
#define PROBLEM_2_H
#include "../problem.h"

struct ListNode_2 {
    int val;
    ListNode_2 *next;
    ListNode_2() : val(0), next(nullptr) {}
    ListNode_2(int x) : val(x), next(nullptr) {}
    ListNode_2(int x, ListNode_2 *next) : val(x), next(next) {}
    ~ListNode_2() { delete next; }
};

class problem_2 : public problem
{
public:
    bool test() override;

    ListNode_2* addTwoNumbers(const ListNode_2* l1, const ListNode_2* l2);
private:
    bool areSame(ListNode_2 *l1, ListNode_2 *l2);
};



#endif //PROBLEM_2_H
