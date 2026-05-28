#ifndef PROBLEMS_PROBLEM_1871_H
#define PROBLEMS_PROBLEM_1871_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_1871 : public problem {
public:
    bool test() override;

    bool canReach(std::string s, int minJump, int maxJump);
};

#endif //PROBLEMS_PROBLEM_1871_H