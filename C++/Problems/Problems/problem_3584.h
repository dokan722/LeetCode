#ifndef PROBLEMS_PROBLEM_3584_H
#define PROBLEMS_PROBLEM_3584_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_3584 : public problem {
public:
    bool test() override;

    long long maximumProduct(std::vector<int>& nums, int m);
};

#endif //PROBLEMS_PROBLEM_3584_H