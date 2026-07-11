#ifndef PROBLEMS_PROBLEM_274_H
#define PROBLEMS_PROBLEM_274_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_274 : public problem {
public:
    bool test() override;

    int hIndex(std::vector<int>& citations);
};

#endif //PROBLEMS_PROBLEM_274_H