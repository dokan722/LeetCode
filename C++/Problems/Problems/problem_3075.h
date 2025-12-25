#ifndef PROBLEM_3075_H
#define PROBLEM_3075_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3075 : public problem {
public:
    bool test() override;

    long long maximumHappinessSum(std::vector<int>& happiness, int k);
};

#endif //PROBLEM_3075_H
