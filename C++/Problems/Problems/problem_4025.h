#ifndef PROBLEMS_PROBLEM_4025_H
#define PROBLEMS_PROBLEM_4025_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_4025 : public problem {
public:
    bool test() override;

    int minPenalty(int period, std::vector<int>& lights, std::vector<int>& arrivalTime);
};

#endif //PROBLEMS_PROBLEM_4025_H