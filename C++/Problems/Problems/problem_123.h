#ifndef PROBLEMS_PROBLEM_123_H
#define PROBLEMS_PROBLEM_123_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_123 : public problem {
public:
    bool test() override;

    int maxProfit(std::vector<int>& prices);
};

#endif //PROBLEMS_PROBLEM_123_H