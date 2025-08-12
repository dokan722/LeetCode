#ifndef PROBLEM_1475_H
#define PROBLEM_1475_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1475 : public problem {
public:
    bool test() override;

    std::vector<int> finalPrices(std::vector<int>& prices);
};



#endif //PROBLEM_1475_H
