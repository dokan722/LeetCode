#ifndef PROBLEM_2466_H
#define PROBLEM_2466_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2466 : public problem {
public:
    bool test() override;

    int countGoodStrings(int low, int high, int zero, int one);
};

#endif //PROBLEM_2466_H
