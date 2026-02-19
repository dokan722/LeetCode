#ifndef PROBLEMS_PROBLEM_3592_H
#define PROBLEMS_PROBLEM_3592_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3592 : public problem {
public:
    bool test() override;

    std::vector<int> findCoins(std::vector<int>& numWays);
};

#endif //PROBLEMS_PROBLEM_3592_H