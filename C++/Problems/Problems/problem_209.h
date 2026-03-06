#ifndef PROBLEM_209_H
#define PROBLEM_209_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_209 : public problem {
public:
    bool test() override;

    int minSubArrayLen(int target, std::vector<int>& nums);
};

#endif //PROBLEM_209_H
