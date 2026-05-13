#ifndef PROBLEMS_PROBLEM_3689_H
#define PROBLEMS_PROBLEM_3689_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_3689 : public problem {
public:
    bool test() override;

    long long maxTotalValue(std::vector<int>& nums, int k);
};

#endif //PROBLEMS_PROBLEM_3689_H