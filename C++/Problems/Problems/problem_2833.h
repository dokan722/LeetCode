#ifndef PROBLEMS_PROBLEM_2833_H
#define PROBLEMS_PROBLEM_2833_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2833 : public problem {
public:
    bool test() override;

    int furthestDistanceFromOrigin(std::string moves);
};

#endif //PROBLEMS_PROBLEM_2833_H