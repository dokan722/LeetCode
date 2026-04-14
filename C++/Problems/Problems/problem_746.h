#ifndef PROBLEM_746_H
#define PROBLEM_746_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_746 : public problem {
public:
    bool test() override;

    int minCostClimbingStairs(std::vector<int>& cost);
};

#endif //PROBLEM_746_H
