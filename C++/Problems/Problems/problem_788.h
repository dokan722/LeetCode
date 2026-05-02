#ifndef PROBLEMS_PROBLEM_788_H
#define PROBLEMS_PROBLEM_788_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_788 : public problem {
public:
    bool test() override;

    int rotatedDigits(int n);
};

#endif //PROBLEMS_PROBLEM_788_H