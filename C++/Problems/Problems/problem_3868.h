#ifndef PROBLEMS_PROBLEM_3868_H
#define PROBLEMS_PROBLEM_3868_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_3868 : public problem {
public:
    bool test() override;

    int minCost(std::vector<int>& nums1, std::vector<int>& nums2);
};

#endif //PROBLEMS_PROBLEM_3868_H