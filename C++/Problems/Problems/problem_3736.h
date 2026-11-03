#ifndef PROBLEMS_PROBLEM_3736_H
#define PROBLEMS_PROBLEM_3736_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_3736 : public problem {
public:
    bool test() override;

    int minMoves(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_3736_H