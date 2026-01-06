#ifndef PROBLEMS_PROBLEM_2651_H
#define PROBLEMS_PROBLEM_2651_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2651 : public problem {
public:
    bool test() override;

    int findDelayedArrivalTime(int arrivalTime, int delayedTime);
};

#endif //PROBLEMS_PROBLEM_2651_H