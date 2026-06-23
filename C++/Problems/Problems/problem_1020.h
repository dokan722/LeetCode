#ifndef PROBLEM_1020_H
#define PROBLEM_1020_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>

class problem_1020 : public problem {
public:
    bool test() override;

    int numEnclaves(std::vector<std::vector<int>>& grid);
};

#endif //PROBLEM_1020_H
