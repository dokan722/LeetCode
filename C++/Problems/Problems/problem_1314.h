#ifndef PROBLEM_1314_H
#define PROBLEM_1314_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_1314 : public problem {
public:
    bool test() override;

    std::vector<std::vector<int>> matrixBlockSum(std::vector<std::vector<int>>& mat, int k);
};

#endif //PROBLEM_1314_H
