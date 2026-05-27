#ifndef PROBLEM_3121_H
#define PROBLEM_3121_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_3121 : public problem {
public:
    bool test() override;

    int numberOfSpecialChars(std::string word);
};

#endif //PROBLEM_3121_H
