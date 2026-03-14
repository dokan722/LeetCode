#ifndef PROBLEMS_PROBLEM_926_H
#define PROBLEMS_PROBLEM_926_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_926 : public problem {
public:
    bool test() override;

    int minFlipsMonoIncr(std::string s);
};

#endif //PROBLEMS_PROBLEM_926_H