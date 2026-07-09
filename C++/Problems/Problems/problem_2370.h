#ifndef PROBLEMS_PROBLEM_2370_H
#define PROBLEMS_PROBLEM_2370_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_2370 : public problem {
public:
    bool test() override;

    int longestIdealString(std::string s, int k);
};

#endif //PROBLEMS_PROBLEM_2370_H