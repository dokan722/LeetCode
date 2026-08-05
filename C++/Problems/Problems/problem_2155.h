#ifndef PROBLEM_2155_H
#define PROBLEM_2155_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>
#include <cmath>
#include <unordered_map>

class problem_2155 : public problem {
public:
    bool test() override;

    std::vector<int> maxScoreIndices(std::vector<int>& nums);
};

#endif //PROBLEM_2155_H
