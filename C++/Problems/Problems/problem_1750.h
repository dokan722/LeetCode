#ifndef PROBLEM_1750_H
#define PROBLEM_1750_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_1750 : public problem {
public:
    bool test() override;

    int minimumLength(std::string s);
};

#endif //PROBLEM_1750_H
