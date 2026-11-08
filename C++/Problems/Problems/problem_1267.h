#ifndef PROBLEMS_PROBLEM_1267_H
#define PROBLEMS_PROBLEM_1267_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_1267 : public problem {
public:
    bool test() override;

    int countServers(std::vector<std::vector<int>>& grid);
};

#endif //PROBLEMS_PROBLEM_1267_H