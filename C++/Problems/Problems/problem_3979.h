#ifndef PROBLEMS_PROBLEM_3979_H
#define PROBLEMS_PROBLEM_3979_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_3979 : public problem {
public:
    bool test() override;

    int maxValidPairSum(std::vector<int>& nums, int k);
};

#endif //PROBLEMS_PROBLEM_3979_H