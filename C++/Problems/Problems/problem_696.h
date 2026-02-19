#ifndef PROBLEMS_PROBLEM_696_H
#define PROBLEMS_PROBLEM_696_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_696 : public problem {
public:
    bool test() override;

    int countBinarySubstrings(std::string s);
};

#endif //PROBLEMS_PROBLEM_696_H