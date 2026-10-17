#ifndef PROBLEMS_PROBLEM_2913_H
#define PROBLEMS_PROBLEM_2913_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_2913 : public problem {
public:
    bool test() override;

    int sumCounts(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_2913_H