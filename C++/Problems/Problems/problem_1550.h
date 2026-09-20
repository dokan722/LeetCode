#ifndef PROBLEMS_PROBLEM_1550_H
#define PROBLEMS_PROBLEM_1550_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_1550 : public problem {
public:
    bool test() override;

    bool threeConsecutiveOdds(std::vector<int>& arr);
};

#endif //PROBLEMS_PROBLEM_1550_H