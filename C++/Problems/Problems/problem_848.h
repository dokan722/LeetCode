#ifndef PROBLEMS_PROBLEM_848_H
#define PROBLEMS_PROBLEM_848_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_848 : public problem {
public:
    bool test() override;

    std::string shiftingLetters(std::string s, std::vector<int>& shifts);
};

#endif //PROBLEMS_PROBLEM_848_H