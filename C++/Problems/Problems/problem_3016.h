#ifndef PROBLEM_3016_H
#define PROBLEM_3016_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_3016 : public problem {
public:
    bool test() override;

    int minimumPushes(std::string word);
};

#endif //PROBLEM_3016_H
