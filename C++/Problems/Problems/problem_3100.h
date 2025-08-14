#ifndef PROBLEM_3100_H
#define PROBLEM_3100_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3100 : public problem {
public:
    bool test() override;

    int maxBottlesDrunk(int numBottles, int numExchange);
};



#endif //PROBLEM_3100_H
