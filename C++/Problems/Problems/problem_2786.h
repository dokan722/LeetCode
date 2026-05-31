#ifndef PROBLEMS_PROBLEM_2786_H
#define PROBLEMS_PROBLEM_2786_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_2786 : public problem {
public:
    bool test() override;

    long long maxScore(std::vector<int>& nums, int x);
};

#endif //PROBLEMS_PROBLEM_2786_H