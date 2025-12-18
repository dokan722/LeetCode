#ifndef PROBLEMS_PROBLEM_3652_H
#define PROBLEMS_PROBLEM_3652_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3652 : public problem {
public:
    bool test() override;

    long long maxProfit(std::vector<int>& prices, std::vector<int>& strategy, int k);
};

#endif //PROBLEMS_PROBLEM_3652_H