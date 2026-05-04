#ifndef PROBLEMS_PROBLEM_1367_H
#define PROBLEMS_PROBLEM_1367_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_1386 : public problem {
public:
    bool test() override;

    int maxNumberOfFamilies(int n, std::vector<std::vector<int>>& reservedSeats);
};

#endif //PROBLEMS_PROBLEM_1367_H