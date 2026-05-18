#ifndef PROBLEMS_PROBLEM_3839_H
#define PROBLEMS_PROBLEM_3839_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_3839 : public problem {
public:
    bool test() override;

    int prefixConnected(std::vector<std::string>& words, int k);
};

#endif //PROBLEMS_PROBLEM_3839_H