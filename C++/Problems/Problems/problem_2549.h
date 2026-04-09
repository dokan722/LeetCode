#ifndef PROBLEMS_PROBLEM2549_H
#define PROBLEMS_PROBLEM2549_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2549 : public problem {
public:
    bool test() override;

    int distinctIntegers(int n);
};

#endif //PROBLEMS_PROBLEM2549_H