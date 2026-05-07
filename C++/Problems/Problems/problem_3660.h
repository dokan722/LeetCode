#ifndef PROBLEM_3660_H
#define PROBLEM_3660_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3660 : public problem {
public:
    bool test() override;

    std::vector<int> maxValue(std::vector<int>& nums);
};

#endif //PROBLEM_3660_H
