#ifndef PROBLEMS_PROBLEM_2790_H
#define PROBLEMS_PROBLEM_2790_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_2790 : public problem {
public:
    bool test() override;

    long long maxArrayValue(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_2790_H