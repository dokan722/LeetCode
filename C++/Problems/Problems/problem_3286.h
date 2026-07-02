#ifndef PROBLEM_3286_H
#define PROBLEM_3286_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>

class problem_3286 : public problem {
public:
    bool test() override;

    bool findSafeWalk(std::vector<std::vector<int>>& grid, int health);
};

#endif //PROBLEM_3286_H
