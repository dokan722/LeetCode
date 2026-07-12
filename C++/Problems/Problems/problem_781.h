#ifndef PROBLEMS_PROBLEM_781_H
#define PROBLEMS_PROBLEM_781_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_781 : public problem {
public:
    bool test() override;

    int numRabbits(std::vector<int>& answers);
};

#endif //PROBLEMS_PROBLEM_781_H