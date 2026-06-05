#ifndef PROBLEMS_PROBLEM_3576_H
#define PROBLEMS_PROBLEM_3576_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_3576 : public problem {
public:
    bool test() override;

    bool canMakeEqual(std::vector<int>& nums, int k);
};

#endif //PROBLEMS_PROBLEM_3576_H