#ifndef PROBLEM_318_H
#define PROBLEM_318_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <stack>

class problem_318 : public problem {
public:
    bool test() override;

    int maxProduct(std::vector<std::string>& words);
};

#endif //PROBLEM_318_H
