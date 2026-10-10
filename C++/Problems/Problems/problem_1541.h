#ifndef PROBLEMS_PROBLEM_1541_H
#define PROBLEMS_PROBLEM_1541_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_1541 : public problem {
public:
    bool test() override;

    int minInsertions(std::string s);
};

#endif //PROBLEMS_PROBLEM_1541_H