#ifndef PROBLEM_2706_H
#define PROBLEM_2706_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <stack>

class problem_2706 : public problem {
public:
    bool test() override;

    int buyChoco(std::vector<int>& prices, int money);
};

#endif //PROBLEM_2706_H
