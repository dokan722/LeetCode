#ifndef PROBLEM_80_H
#define PROBLEM_80_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>
#include <cmath>
#include <unordered_map>

class problem_80 : public problem {
public:
    bool test() override;

    int removeDuplicates(std::vector<int>& nums);
};

#endif //PROBLEM_80_H
