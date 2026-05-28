#ifndef PROBLEMS_PROBLEM_495_H
#define PROBLEMS_PROBLEM_495_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_495 : public problem {
public:
    bool test() override;

    int findPoisonedDuration(std::vector<int>& timeSeries, int duration);
};

#endif //PROBLEMS_PROBLEM_495_H