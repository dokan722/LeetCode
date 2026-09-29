#ifndef PROBLEMS_PROBLEM_1614_H
#define PROBLEMS_PROBLEM_1614_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_1614 : public problem {
public:
    bool test() override;

    int maxDepth(std::string s);
};

#endif //PROBLEMS_PROBLEM_1614_H