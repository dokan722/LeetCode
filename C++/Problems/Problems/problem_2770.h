#ifndef PROBLEM_2770_H
#define PROBLEM_2770_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_2770 : public problem {
public:
    bool test() override;

    int maximumJumps(std::vector<int>& nums, int target) ;
};

#endif //PROBLEM_2770_H
