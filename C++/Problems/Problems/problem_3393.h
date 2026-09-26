#ifndef PROBLEMS_PROBLEM_3393_H
#define PROBLEMS_PROBLEM_3393_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_3393 : public problem {
public:
    bool test() override;

    int countPathsWithXorValue(std::vector<std::vector<int>>& grid, int k);
};

#endif //PROBLEMS_PROBLEM_3393_H