#ifndef PROBLEM_322_H
#define PROBLEM_322_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>

class problem_322 : public problem {
public:
    bool test() override;

    int coinChange(std::vector<int>& coins, int amount);
};

#endif //PROBLEM_322_H
