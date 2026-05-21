#ifndef PROBLEMS_PROBLEM_740_H
#define PROBLEMS_PROBLEM_740_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_740 : public problem {
public:
    bool test() override;

    int deleteAndEarn(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_740_H