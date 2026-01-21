#ifndef PROBLEM_3315_H
#define PROBLEM_3315_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3315 : public problem {
public:
    bool test() override;

    std::vector<int> minBitwiseArray(std::vector<int>& nums);
};

#endif //PROBLEM_3315_H
