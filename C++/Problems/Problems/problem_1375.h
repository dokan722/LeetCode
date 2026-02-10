#ifndef PROBLEM_1375_H
#define PROBLEM_1375_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_1375 : public problem {
public:
    bool test() override;

    int numTimesAllBlue(std::vector<int>& flips);
};

#endif //PROBLEM_1375_H
