#ifndef PROBLEMS_PROBLEM_2453_H
#define PROBLEMS_PROBLEM_2453_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2453 : public problem {
public:
    bool test() override;

    int destroyTargets(std::vector<int>& nums, int space);
};

#endif //PROBLEMS_PROBLEM_2453_H