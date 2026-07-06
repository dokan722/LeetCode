#ifndef PROBLEM_930_H
#define PROBLEM_930_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>

class problem_930 : public problem {
public:
    bool test() override;

    int numSubarraysWithSum(std::vector<int>& nums, int goal);
};

#endif //PROBLEM_930_H
