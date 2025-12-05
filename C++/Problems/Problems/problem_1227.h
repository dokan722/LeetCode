#ifndef PROBLEM_1227_H
#define PROBLEM_1227_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1227 : public problem {
public:
    bool test() override;

    double nthPersonGetsNthSeat(int n);
};

#endif //PROBLEM_1227_H
