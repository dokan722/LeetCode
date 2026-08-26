#ifndef PROBLEMS_PROBLEM_2904_H
#define PROBLEMS_PROBLEM_2904_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_2904 : public problem {
public:
    bool test() override;

    std::string shortestBeautifulSubstring(std::string s, int k);
};

#endif //PROBLEMS_PROBLEM_2904_H