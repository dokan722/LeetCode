#ifndef PROBLEMS_PROBLEM_3532_H
#define PROBLEMS_PROBLEM_3532_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_3532 : public problem {
public:
    bool test() override;

    std::vector<bool> pathExistenceQueries(int n, std::vector<int>& nums, int maxDiff, std::vector<std::vector<int>>& queries);
};
#endif //PROBLEMS_PROBLEM_3532_H