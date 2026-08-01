#ifndef PROBLEM_486_H
#define PROBLEM_486_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>
#include <cmath>
#include <unordered_map>

class problem_486 : public problem {
public:
    bool test() override;

    bool predictTheWinner(std::vector<int>& nums);
};

#endif //PROBLEM_486_H
