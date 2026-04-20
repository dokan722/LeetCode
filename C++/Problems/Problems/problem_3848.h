#ifndef PROBLEM_3848_H
#define PROBLEM_3848_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3848 : public problem {
public:
    bool test() override;

    bool isDigitorialPermutation(int n);
};

#endif //PROBLEM_3848_H
