#ifndef PROBLEM_3153_H
#define PROBLEM_3153_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>
#include <cmath>
#include <unordered_map>

class problem_3153 : public problem {
public:
    bool test() override;

    long long sumDigitDifferences(std::vector<int>& nums);
};

#endif //PROBLEM_3153_H
