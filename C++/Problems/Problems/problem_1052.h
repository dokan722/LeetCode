#ifndef PROBLEM_1052_H
#define PROBLEM_1052_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>

class problem_1052 : public problem {
public:
    bool test() override;

    int maxSatisfied(std::vector<int>& customers, std::vector<int>& grumpy, int minutes);
};

#endif //PROBLEM_1052_H
