#ifndef PROBLEMS_PROBLEM_714_H
#define PROBLEMS_PROBLEM_714_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_714 : public problem {
public:
    bool test() override;

    int maxProfit(std::vector<int>& prices, int fee);
};

#endif //PROBLEMS_PROBLEM_714_H