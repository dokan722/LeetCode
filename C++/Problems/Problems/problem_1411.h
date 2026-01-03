#ifndef PROBLEMS_PROBLEM_1411_H
#define PROBLEMS_PROBLEM_1411_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1411 : public problem {
public:
    bool test() override;

    int numOfWays(int n);
};

#endif //PROBLEMS_PROBLEM_1411_H