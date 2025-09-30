#ifndef PROBLEM_1344_H
#define PROBLEM_1344_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1344: public problem {
public:
    bool test() override;

    double angleClock(int hour, int minutes);
};



#endif //PROBLEM_1344_H
