#ifndef PROBLEMS_PROBLEM_3718_H
#define PROBLEMS_PROBLEM_3718_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_3718 : public problem {
public:
    bool test() override;

    int missingMultiple(std::vector<int>& nums, int k);
};
#endif //PROBLEMS_PROBLEM_3718_H