#ifndef PROBLEMS_PROBLEM_3968_H
#define PROBLEMS_PROBLEM_3968_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_3968 : public problem {
public:
    bool test() override;

    int maxDistance(std::string moves);
};

#endif //PROBLEMS_PROBLEM_3968_H