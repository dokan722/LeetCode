#ifndef PROBLEMS_PROBLEM_3254_H
#define PROBLEMS_PROBLEM_3254_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_3254 : public problem {
public:
    bool test() override;

    std::vector<int> resultsArray(std::vector<int>& nums, int k);
};

#endif //PROBLEMS_PROBLEM_3254_H