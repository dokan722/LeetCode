#ifndef PROBLEM_2028_H
#define PROBLEM_2028_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>

class problem_2028 : public problem {
public:
    bool test() override;

    std::vector<int> missingRolls(std::vector<int>& rolls, int mean, int n);
};

#endif //PROBLEM_2028_H
