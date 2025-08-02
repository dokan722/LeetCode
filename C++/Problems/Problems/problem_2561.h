#ifndef PROBLEM_2561_H
#define PROBLEM_2561_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2561 : public problem {
public:
    bool test() override;

    long long minCost(std::vector<int>& basket1, std::vector<int>& basket2);
};



#endif //PROBLEM_2561_H
