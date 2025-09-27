#ifndef PROBLEM_1701_H
#define PROBLEM_1701_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1701: public problem {
public:
    bool test() override;

    double averageWaitingTime(std::vector<std::vector<int>>& customers);
};



#endif //PROBLEM_1701_H
