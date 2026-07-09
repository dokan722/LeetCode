#ifndef PROBLEMS_PROBLEM_2844_H
#define PROBLEMS_PROBLEM_2844_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_2844 : public problem {
public:
    bool test() override;

    int minimumOperations(std::string num);
};

#endif //PROBLEMS_PROBLEM_2844_H