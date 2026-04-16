#ifndef PROBLEM_520_H
#define PROBLEM_520_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_520 : public problem {
public:
    bool test() override;

    bool detectCapitalUse(std::string word);
};

#endif //PROBLEM_520_H
