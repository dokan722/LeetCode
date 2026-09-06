#ifndef PROBLEMS_PROBLEM_115_H
#define PROBLEMS_PROBLEM_115_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_115 : public problem {
public:
    bool test() override;

    int numDistinct(std::string s, std::string t);
};

#endif //PROBLEMS_PROBLEM_115_H