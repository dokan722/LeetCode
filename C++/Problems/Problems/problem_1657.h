#ifndef PROBLEMS_PROBLEM_1657_H
#define PROBLEMS_PROBLEM_1657_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_1657 : public problem {
public:
    bool test() override;

    bool closeStrings(std::string word1, std::string word2);
};

#endif //PROBLEMS_PROBLEM_1657_H