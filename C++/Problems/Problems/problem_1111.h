#ifndef PROBLEMS_PROBLEM_1111_H
#define PROBLEMS_PROBLEM_1111_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_1111 : public problem {
public:
    bool test() override;

    std::vector<int> maxDepthAfterSplit(std::string seq);
};

#endif //PROBLEMS_PROBLEM_1111_H