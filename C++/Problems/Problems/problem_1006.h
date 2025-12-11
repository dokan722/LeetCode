#ifndef PROBLEMS_PROBLEM_1006_H
#define PROBLEMS_PROBLEM_1006_H

#include "../problem.h"
#include <vector>
#include <string>

class problem_1006 : public problem {
public:
    bool test() override;

    int clumsy(int n);
};

#endif //PROBLEMS_PROBLEM_1006_H