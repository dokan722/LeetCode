#ifndef PROBLEMS_PROBLEM_2275_H
#define PROBLEMS_PROBLEM_2275_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_2275 : public problem {
public:
    bool test() override;

    int largestCombination(std::vector<int>& candidates);
};

#endif //PROBLEMS_PROBLEM_2275_H