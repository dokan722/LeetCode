#ifndef PROBLEMS_PROBLEM_3226_H
#define PROBLEMS_PROBLEM_3226_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_3226 : public problem {
public:
    bool test() override;

    int minChanges(int n, int k);
};

#endif //PROBLEMS_PROBLEM_3226_H