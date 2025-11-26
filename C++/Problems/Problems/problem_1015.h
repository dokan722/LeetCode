#ifndef PROBLEM_1015_H
#define PROBLEM_1015_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1015 : public problem {
public:
    bool test() override;

    int smallestRepunitDivByK(int k);
};

#endif //PROBLEM_1015_H
