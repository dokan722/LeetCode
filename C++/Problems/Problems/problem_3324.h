#ifndef PROBLEMS_PROBLEM_3324_H
#define PROBLEMS_PROBLEM_3324_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3324 : public problem {
public:
    bool test() override;

    std::vector<std::string> stringSequence(std::string target);
};

#endif //PROBLEMS_PROBLEM_3324_H