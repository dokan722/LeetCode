#ifndef PROBLEMS_PROBLEM_1967_H
#define PROBLEMS_PROBLEM_1967_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_1967 : public problem {
public:
    bool test() override;

    int numOfStrings(std::vector<std::string>& patterns, std::string word);
};

#endif //PROBLEMS_PROBLEM_1967_H