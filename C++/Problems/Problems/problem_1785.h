#ifndef PROBLEMS_PROBLEM_1785_H
#define PROBLEMS_PROBLEM_1785_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_1785 : public problem {
public:
    bool test() override;

    int minElements(std::vector<int>& nums, int limit, int goal);
};

#endif //PROBLEMS_PROBLEM_1785_H