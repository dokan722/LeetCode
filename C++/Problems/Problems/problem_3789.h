#ifndef PROBLEMS_PROBLEM_3789_H
#define PROBLEMS_PROBLEM_3789_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_3789 : public problem {
public:
    bool test() override;

    long long minimumCost(int cost1, int cost2, int costBoth, int need1, int need2);
};

#endif //PROBLEMS_PROBLEM_3789_H