#ifndef PROBLEM_2553_H
#define PROBLEM_2553_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_2553 : public problem {
public:
    bool test() override;

    std::vector<int> separateDigits(std::vector<int>& nums);
};

#endif //PROBLEM_2553_H
