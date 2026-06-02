#ifndef PROBLEMS_PROBLEM_2550_H
#define PROBLEMS_PROBLEM_2550_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_2550 : public problem {
public:
    bool test() override;

    int monkeyMove(int n);
};

#endif //PROBLEMS_PROBLEM_2550_H