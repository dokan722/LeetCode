#ifndef PROBLEM_1518_H
#define PROBLEM_1518_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1518 : public problem {
public:
    bool test() override;

    int numWaterBottles(int numBottles, int numExchange);
};



#endif //PROBLEM_1518_H
