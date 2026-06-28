#ifndef PROBLEMS_PROBLEM_2909_H
#define PROBLEMS_PROBLEM_2909_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_2909 : public problem {
public:
    bool test() override;

    int minimumSum(std::vector<int>& nums);
};
#endif //PROBLEMS_PROBLEM_2909_H