#ifndef PROBLEMS_PROBLEM_154_H
#define PROBLEMS_PROBLEM_154_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_154 : public problem {
public:
    bool test() override;

    int findMin(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_154_H