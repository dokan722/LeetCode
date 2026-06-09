#ifndef PROBLEM_540_H
#define PROBLEM_540_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_540 : public problem {
public:
    bool test() override;

    int singleNonDuplicate(std::vector<int>& nums);
};

#endif //PROBLEM_540_H
