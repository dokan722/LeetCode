#ifndef PROBLEM_2644_H
#define PROBLEM_2644_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2644 : public problem {
public:
    bool test() override;

    int maxDivScore(std::vector<int>& nums, std::vector<int>& divisors);
};

#endif //PROBLEM_2644_H
