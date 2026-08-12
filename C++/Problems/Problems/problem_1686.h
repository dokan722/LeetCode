#ifndef PROBLEM_1686_H
#define PROBLEM_1686_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>
#include <cmath>
#include <unordered_map>

class problem_1686 : public problem {
public:
    bool test() override;

    int stoneGameVI(std::vector<int>& aliceValues, std::vector<int>& bobValues);
};

#endif //PROBLEM_1686_H
