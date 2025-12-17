#ifndef PROBLEMS_PROBLEM_3573_H
#define PROBLEMS_PROBLEM_3573_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3573 : public problem {
public:
    bool test() override;

    long long maximumProfit(std::vector<int>& prices, int k);
};

#endif //PROBLEMS_PROBLEM_3573_H