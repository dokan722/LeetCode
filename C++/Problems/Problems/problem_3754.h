#ifndef PROBLEM_3754_H
#define PROBLEM_3754_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>

class problem_3754 : public problem {
public:
    bool test() override;

    long long sumAndMultiply(int n);
};

#endif //PROBLEM_3754_H
