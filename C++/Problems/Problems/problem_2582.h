#ifndef PROBLEMS_PROBLEM_2582_H
#define PROBLEMS_PROBLEM_2582_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2582 : public problem {
public:
    bool test() override;

    int passThePillow(int n, int time);
};

#endif //PROBLEMS_PROBLEM_2582_H