#ifndef PROBLEM_2952_H
#define PROBLEM_2952_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_2952 : public problem {
public:
    bool test() override;

    int minimumAddedCoins(std::vector<int>& coins, int target);
};

#endif //PROBLEM_2952_H
