#ifndef PROBLEMS_PROBLEM_1138_H
#define PROBLEMS_PROBLEM_1138_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_1138 : public problem {
public:
    bool test() override;

    std::string alphabetBoardPath(std::string target);
};

#endif //PROBLEMS_PROBLEM_1138_H