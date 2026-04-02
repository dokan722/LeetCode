#ifndef PROBLEM_2730_H
#define PROBLEM_2730_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2730 : public problem {
public:
    bool test() override;

    int longestSemiRepetitiveSubstring(std::string s);
};

#endif //PROBLEM_2730_H
