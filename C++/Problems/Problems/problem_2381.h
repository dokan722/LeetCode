#ifndef PROBLEMS_PROBLEM_2381_H
#define PROBLEMS_PROBLEM_2381_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_2381 : public problem {
public:
    bool test() override;

    std::string shiftingLetters(std::string s, std::vector<std::vector<int>>&  shifts);
};

#endif //PROBLEMS_PROBLEM_2381_H