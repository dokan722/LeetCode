#ifndef PROBLEMS_PROBLEM_33_H
#define PROBLEMS_PROBLEM_33_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_33 : public problem {
public:
    bool test() override;

    int search(std::vector<int>& nums, int target);
};

#endif //PROBLEMS_PROBLEM_33_H