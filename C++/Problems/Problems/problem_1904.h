#ifndef PROBLEMS_PROBLEM_1904_H
#define PROBLEMS_PROBLEM_1904_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_1904 : public problem {
public:
    bool test() override;

    int numberOfRounds(std::string loginTime, std::string logoutTime);
};

#endif //PROBLEMS_PROBLEM_1904_H