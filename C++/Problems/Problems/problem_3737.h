#ifndef PROBLEM_3737_H
#define PROBLEM_3737_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3737 : public problem {
public:
    bool test() override;

    int countMajoritySubarrays(std::vector<int>& nums, int target);
};

#endif //PROBLEM_3737_H
