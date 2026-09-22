#ifndef PROBLEMS_PROBLEM_3524_H
#define PROBLEMS_PROBLEM_3524_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_3524 : public problem {
public:
    bool test() override;

    std::vector<long long> resultArray(std::vector<int>& nums, int k);
};

#endif //PROBLEMS_PROBLEM_3524_H