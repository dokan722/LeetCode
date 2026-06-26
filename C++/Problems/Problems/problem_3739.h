#ifndef PROBLEMS_PROBLEM_3739_H
#define PROBLEMS_PROBLEM_3739_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_3739 : public problem {
public:
    bool test() override;

    long long countMajoritySubarrays(std::vector<int>& nums, int target) ;
};

#endif //PROBLEMS_PROBLEM_3739_H