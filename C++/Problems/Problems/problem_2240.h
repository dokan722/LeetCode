#ifndef PROBLEMS_PROBLEM_2240_H
#define PROBLEMS_PROBLEM_2240_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2240 : public problem {
public:
    bool test() override;

    long long waysToBuyPensPencils(int total, int cost1, int cost2);
};

#endif //PROBLEMS_PROBLEM_2240_H