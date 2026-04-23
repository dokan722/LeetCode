#ifndef PROBLEMS_PROBLEM_3084_H
#define PROBLEMS_PROBLEM_3084_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3084 : public problem {
public:
    bool test() override;

    long long countSubstrings(std::string s, char c);
};

#endif //PROBLEMS_PROBLEM_3084_H