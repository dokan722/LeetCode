#ifndef PROBLEMS_PROBLEM_2806_H
#define PROBLEMS_PROBLEM_2806_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2806 : public problem {
public:
    bool test() override;

    int accountBalanceAfterPurchase(int purchaseAmount);
};

#endif //PROBLEMS_PROBLEM_2806_H