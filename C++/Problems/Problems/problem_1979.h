#ifndef PROBLEM_1979_H
#define PROBLEM_1979_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>

class problem_1979 : public problem {
public:
    bool test() override;

    int findGCD(std::vector<int>& nums);
};

#endif //PROBLEM_1979_H
