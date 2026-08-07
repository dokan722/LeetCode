#ifndef PROBLEM_2482_H
#define PROBLEM_2482_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>
#include <cmath>
#include <unordered_map>

class problem_2482 : public problem {
public:
    bool test() override;

    std::vector<std::vector<int>> onesMinusZeros(std::vector<std::vector<int>>& grid);
};

#endif //PROBLEM_2482_H
