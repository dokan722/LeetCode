#ifndef PROBLEM_3065_H
#define PROBLEM_3065_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>

class problem_3065 : public problem {
public:
    bool test() override;

    int minOperations(std::vector<int>& nums, int k);
};

#endif //PROBLEM_3065_H
