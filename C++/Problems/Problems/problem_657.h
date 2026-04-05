#ifndef PROBLEM_657_H
#define PROBLEM_657_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_657 : public problem {
public:
    bool test() override;

    bool judgeCircle(std::string moves);
};

#endif //PROBLEM_657_H
