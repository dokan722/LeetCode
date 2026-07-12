#ifndef PROBLEMS_PROBLEM_1331_H
#define PROBLEMS_PROBLEM_1331_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_1331 : public problem {
public:
    bool test() override;

    std::vector<int> arrayRankTransform(std::vector<int>& arr);
};

#endif //PROBLEMS_PROBLEM_1331_H