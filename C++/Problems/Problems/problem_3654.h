#ifndef PROBLEMS_PROBLEM_3654_H
#define PROBLEMS_PROBLEM_3654_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_3654 : public problem {
public:
    bool test() override;

    long long minArraySum(std::vector<int>& nums, int k);
};

#endif //PROBLEMS_PROBLEM_3654_H