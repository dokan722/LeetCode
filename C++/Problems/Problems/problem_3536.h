#ifndef PROBLEMS_PROBLEM_3536_H
#define PROBLEMS_PROBLEM_3536_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_3536 : public problem {
public:
    bool test() override;

    int maxProduct(int n);
};

#endif //PROBLEMS_PROBLEM_3536_H