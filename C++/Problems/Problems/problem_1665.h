#ifndef PROBLEM_1665_H
#define PROBLEM_1665_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_1665 : public problem {
public:
    bool test() override;

    int minimumEffort(std::vector<std::vector<int>>& tasks);
};

#endif //PROBLEM_1665_H
