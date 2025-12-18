#ifndef PROBLEMS_PROBLEM_188_H
#define PROBLEMS_PROBLEM_188_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_188 : public problem {
public:
    bool test() override;

    int maxProfit(int k, std::vector<int>& prices);
};

#endif //PROBLEMS_PROBLEM_188_H