#ifndef PROBLEM_2481_H
#define PROBLEM_2481_H


#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2481 : public problem {
public:
    bool test() override;

    int numberOfCuts(int n);
};

#endif //PROBLEM_2481_H
