#ifndef PROBLEMS_PROBLEM_1829_H
#define PROBLEMS_PROBLEM_1829_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_1829 : public problem {
public:
    bool test() override;

    std::vector<int> getMaximumXor(std::vector<int>& nums, int maximumBit);
};

#endif //PROBLEMS_PROBLEM_1829_H