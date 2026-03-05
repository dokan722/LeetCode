#ifndef PROBLEM_1758_H
#define PROBLEM_1758_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_1758 : public problem {
public:
    bool test() override;

    int minOperations(std::string s);
};

#endif //PROBLEM_1758_H
