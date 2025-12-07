#ifndef PROBLEMS_PROBLEM_1523_H
#define PROBLEMS_PROBLEM_1523_H

#include "../problem.h"
#include <vector>
#include <string>

class problem_1523 : public problem {
public:
    bool test() override;

    int countOdds(int low, int high);
};

#endif //PROBLEMS_PROBLEM_1523_H