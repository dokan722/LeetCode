#ifndef PROBLEM_121_H
#define PROBLEM_121_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_121 : public problem {
public:
    bool test() override;

    int maxProfit(std::vector<int>& prices);
};



#endif //PROBLEM_121_H
