#ifndef PROBLEM_650_H
#define PROBLEM_650_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_650 : public problem {
public:
    bool test() override;

    int minSteps(int n);
};

#endif //PROBLEM_650_H
