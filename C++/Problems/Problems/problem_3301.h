#ifndef PROBLEMS_PROBLEM_3301_H
#define PROBLEMS_PROBLEM_3301_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3301 : public problem {
public:
    bool test() override;

    long long maximumTotalSum(std::vector<int>& maximumHeight);
};

#endif //PROBLEMS_PROBLEM_3301_H