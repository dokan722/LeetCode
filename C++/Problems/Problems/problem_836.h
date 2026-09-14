#ifndef PROBLEMS_PROBLEM_836_H
#define PROBLEMS_PROBLEM_836_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_836 : public problem {
public:
    bool test() override;

    bool isRectangleOverlap(std::vector<int>& rec1, std::vector<int>& rec2);
};

#endif //PROBLEMS_PROBLEM_836_H