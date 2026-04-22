#ifndef PROBLEM_3557_H
#define PROBLEM_3557_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3557 : public problem {
public:
    bool test() override;

    int maxSubstrings(std::string word);
};

#endif //PROBLEM_3557_H
