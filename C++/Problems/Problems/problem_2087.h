#ifndef PROBLEM_2087_H
#define PROBLEM_2087_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>

class problem_2087 : public problem {
public:
    bool test() override;

    int minCost(std::vector<int>& startPos, std::vector<int>& homePos, std::vector<int>& rowCosts, std::vector<int>& colCosts);
};

#endif //PROBLEM_2087_H
