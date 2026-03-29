#ifndef PROBLEMS_PROBLEM_561_H
#define PROBLEMS_PROBLEM_561_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_561 : public problem {
public:
    bool test() override;

    int arrayPairSum(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_561_H