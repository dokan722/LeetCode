#ifndef PROBLEMS_PROBLEM_1674_H
#define PROBLEMS_PROBLEM_1674_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_1674 : public problem {
public:
    bool test() override;

    int minMoves(std::vector<int>& nums, int limit);
};

#endif //PROBLEMS_PROBLEM_1674_H