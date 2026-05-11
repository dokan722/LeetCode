#ifndef PROBLEM_2216_H
#define PROBLEM_2216_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_2216 : public problem {
public:
    bool test() override;

    int minDeletion(std::vector<int>& nums);
};

#endif //PROBLEM_2216_H
