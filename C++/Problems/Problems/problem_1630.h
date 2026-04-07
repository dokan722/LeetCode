#ifndef PROBLEM_1630_H
#define PROBLEM_1630_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_1630 : public problem {
public:
    bool test() override;

    std::vector<bool> checkArithmeticSubarrays(std::vector<int>& nums, std::vector<int>& l, std::vector<int>& r);
};

#endif //PROBLEM_1630_H
