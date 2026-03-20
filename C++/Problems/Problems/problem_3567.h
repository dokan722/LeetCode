#ifndef PROBLEM_3567_H
#define PROBLEM_3567_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3567 : public problem {
public:
    bool test() override;

    std::vector<std::vector<int>> minAbsDiff(std::vector<std::vector<int>>& grid, int k);
};

#endif //PROBLEM_3567_H
