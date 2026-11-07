#ifndef PROBLEMS_PROBLEM_849_H
#define PROBLEMS_PROBLEM_849_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_849 : public problem {
public:
    bool test() override;

    int maxDistToClosest(std::vector<int>& seats);
};

#endif //PROBLEMS_PROBLEM_849_H