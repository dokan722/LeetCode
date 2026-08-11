#ifndef PROBLEM_2996_H
#define PROBLEM_2996_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>
#include <cmath>
#include <unordered_map>

class problem_2996 : public problem {
public:
    bool test() override;

    int missingInteger(std::vector<int>& nums);
};

#endif //PROBLEM_2996_H
