#ifndef PROBLEM_2871_H
#define PROBLEM_2871_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2871 : public problem {
public:
    bool test() override;

    int maxSubarrays(std::vector<int>& nums);
};

#endif //PROBLEM_2871_H
