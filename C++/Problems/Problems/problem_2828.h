#ifndef PROBLEMS_PROBLEM_2828_H
#define PROBLEMS_PROBLEM_2828_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_2828 : public problem {
public:
    bool test() override;

    bool isAcronym(std::vector<std::string>& words, std::string s);
};

#endif //PROBLEMS_PROBLEM_2828_H