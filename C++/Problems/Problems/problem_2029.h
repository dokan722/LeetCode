#ifndef PROBLEM_2029_H
#define PROBLEM_2029_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>
#include <cmath>
#include <unordered_map>

class problem_2029 : public problem {
public:
    bool test() override;

    bool stoneGameIX(std::vector<int>& stones);
};

#endif //PROBLEM_2029_H
