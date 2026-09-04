#ifndef PROBLEMS_PROBLEM_3903_H
#define PROBLEMS_PROBLEM_3903_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_3903 : public problem {
public:
    bool test() override;

    int firstStableIndex(std::vector<int>& nums, int k);
};

#endif //PROBLEMS_PROBLEM_3903_H