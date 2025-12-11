#ifndef PROBLEMS_PROBLEM_2413_H
#define PROBLEMS_PROBLEM_2413_H

#include "../problem.h"
#include <vector>
#include <string>

class problem_2413 : public problem {
public:
    bool test() override;

    int smallestEvenMultiple(int n);
};

#endif //PROBLEMS_PROBLEM_2413_H