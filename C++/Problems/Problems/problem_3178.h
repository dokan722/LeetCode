#ifndef PROBLEMS_PROBLEM_3178_H
#define PROBLEMS_PROBLEM_3178_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3178 : public problem {
public:
    bool test() override;

    int numberOfChild(int n, int k);
};

#endif //PROBLEMS_PROBLEM_3178_H