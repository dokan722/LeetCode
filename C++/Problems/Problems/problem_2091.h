#ifndef PROBLEMS_PROBLEM_2091_H
#define PROBLEMS_PROBLEM_2091_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_2019 : public problem {
public:
    bool test() override;

    int minimumDeletions(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_2091_H