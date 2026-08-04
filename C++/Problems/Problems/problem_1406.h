#ifndef PROBLEM_1406_H
#define PROBLEM_1406_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>
#include <cmath>
#include <unordered_map>

class problem_1406 : public problem {
public:
    bool test() override;

    std::string stoneGameIII(std::vector<int>& stoneValue);
};

#endif //PROBLEM_1406_H
