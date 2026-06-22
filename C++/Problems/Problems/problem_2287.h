#ifndef PROBLEMS_PROBLEM_2287_H
#define PROBLEMS_PROBLEM_2287_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_2287 : public problem {
public:
    bool test() override;

    int rearrangeCharacters(std::string s, std::string target);
};

#endif //PROBLEMS_PROBLEM_2287_H