#ifndef PROBLEMS_PROBLEM_2559_H
#define PROBLEMS_PROBLEM_2559_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_2559 : public problem {
public:
    bool test() override;

    std::vector<int> vowelStrings(std::vector<std::string>& words, std::vector<std::vector<int>>& queries);
};

#endif //PROBLEMS_PROBLEM_2559_H