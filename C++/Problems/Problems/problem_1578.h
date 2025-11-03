#ifndef PROBLEM_1578_H
#define PROBLEM_1578_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1578 : public problem {
public:
    bool test() override;

    int minCost(std::string colors, std::vector<int>& neededTime);
};



#endif //PROBLEM_1578_H
