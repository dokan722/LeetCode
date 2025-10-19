#ifndef PROBLEM_122_H
#define PROBLEM_122_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_122 : public problem {
public:
    bool test() override;

    int maxProfit(std::vector<int>& prices);
};



#endif //PROBLEM_122_H
