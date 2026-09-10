#ifndef PROBLEMS_PROBLEM_3870_H
#define PROBLEMS_PROBLEM_3870_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_3870 : public problem {
public:
    bool test() override;

    int countCommas(int n);
};

#endif //PROBLEMS_PROBLEM_3870_H