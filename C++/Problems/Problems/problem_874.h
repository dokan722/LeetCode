#ifndef PROBLEM_874_H
#define PROBLEM_874_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_874 : public problem {
public:
    bool test() override;

    int robotSim(std::vector<int>& commands, std::vector<std::vector<int>>& obstacles);
};

#endif //PROBLEM_874_H
