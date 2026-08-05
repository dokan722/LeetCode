#ifndef PROBLEM_3310_H
#define PROBLEM_3310_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>
#include <cmath>
#include <unordered_map>

class problem_3310 : public problem {
public:
    bool test() override;

    std::vector<int> remainingMethods(int n, int k, std::vector<std::vector<int>>& invocations);
};

#endif //PROBLEM_3310_H
