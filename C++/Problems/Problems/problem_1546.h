#ifndef PROBLEM_1546_H
#define PROBLEM_1546_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>

class problem_1546 : public problem {
public:
    bool test() override;

    int maxNonOverlapping(std::vector<int>& nums, int target);
};

#endif //PROBLEM_1546_H
