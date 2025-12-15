#ifndef PROBLEMS_PROBLEM_2110_H
#define PROBLEMS_PROBLEM_2110_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2110 : public problem {
public:
    bool test() override;

    long long getDescentPeriods(std::vector<int>& prices);
};

#endif //PROBLEMS_PROBLEM_2110_H