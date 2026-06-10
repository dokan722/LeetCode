#ifndef PROBLEM_217_H
#define PROBLEM_217_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_217 : public problem {
public:
    bool test() override;

    bool containsDuplicate(std::vector<int>& nums);
};

#endif //PROBLEM_217_H
