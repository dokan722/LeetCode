#ifndef PROBLEMS_PROBLEM_198_H
#define PROBLEMS_PROBLEM_198_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_198 : public problem {
public:
    bool test() override;

    int rob(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_198_H