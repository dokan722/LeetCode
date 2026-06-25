#ifndef PROBLEMS_PROBLEM_1759_H
#define PROBLEMS_PROBLEM_1759_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_1759 : public problem {
public:
    bool test() override;

    int countHomogenous(std::string s);
};

#endif //PROBLEMS_PROBLEM_1759_H