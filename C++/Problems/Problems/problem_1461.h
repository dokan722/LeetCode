#ifndef PROBLEMS_PROBLEM_1461_H
#define PROBLEMS_PROBLEM_1461_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_1461 : public problem {
public:
    bool test() override;

    bool hasAllCodes(std::string s, int k);
};

#endif //PROBLEMS_PROBLEM_1461_H