#ifndef PROBLEMS_PROBLEM_789_H
#define PROBLEMS_PROBLEM_789_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_789 : public problem {
public:
    bool test() override;

    bool escapeGhosts(std::vector<std::vector<int>>& ghosts, std::vector<int>& target);
};

#endif //PROBLEMS_PROBLEM_789_H