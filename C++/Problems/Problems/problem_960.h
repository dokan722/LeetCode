#ifndef PROBLEMS_PROBLEM_960_H
#define PROBLEMS_PROBLEM_960_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_960 : public problem {
public:
    bool test() override;

    int minDeletionSize(std::vector<std::string>& strs);
};

#endif //PROBLEMS_PROBLEM_960_H