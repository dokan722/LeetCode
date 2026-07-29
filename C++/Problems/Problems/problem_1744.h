#ifndef PROBLEM_1744_H
#define PROBLEM_1744_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>

class problem_1744 : public problem {
public:
    bool test() override;

    std::vector<bool> canEat(std::vector<int>& candiesCount, std::vector<std::vector<int>>& queries);
};

#endif //PROBLEM_1744_H
