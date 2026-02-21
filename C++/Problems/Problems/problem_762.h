#ifndef PROBLEMS_PROBLEM_762_H
#define PROBLEMS_PROBLEM_762_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_762 : public problem {
public:
    bool test() override;

    int countPrimeSetBits(int left, int right);
};

#endif //PROBLEMS_PROBLEM_762_H