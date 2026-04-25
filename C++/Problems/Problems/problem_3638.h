#ifndef PROBLEMS_PROBLEM_3638_H
#define PROBLEMS_PROBLEM_3638_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3638 : public problem {
public:
    bool test() override;

    int maxBalancedShipments(std::vector<int>& weight);
};

#endif //PROBLEMS_PROBLEM_3638_H