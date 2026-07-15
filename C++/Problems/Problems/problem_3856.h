#ifndef PROBLEM_3856_H
#define PROBLEM_3856_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>

class problem_3856 : public problem {
public:
    bool test() override;

    int gcdOfOddEvenSums(int n);
};

#endif //PROBLEM_3856_H
