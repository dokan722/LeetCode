#ifndef PROBLEMS_PROBLEM_2420_H
#define PROBLEMS_PROBLEM_2420_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_2420 : public problem {
public:
    bool test() override;

    std::vector<int> goodIndices(std::vector<int>& nums, int k);
};

#endif //PROBLEMS_PROBLEM_2420_H