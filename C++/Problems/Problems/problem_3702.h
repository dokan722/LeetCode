#ifndef PROBLEMS_PROBLEM_3702_H
#define PROBLEMS_PROBLEM_3702_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_3702 : public problem {
public:
    bool test() override;

    int longestSubsequence(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_3702_H