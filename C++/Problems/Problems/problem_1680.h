#ifndef PROBLEM_1680_H
#define PROBLEM_1680_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_1680 : public problem {
public:
    bool test() override;

    int concatenatedBinary(int n);
};

#endif //PROBLEM_1680_H
