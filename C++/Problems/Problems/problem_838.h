#ifndef PROBLEMS_PROBLEM_838_H
#define PROBLEMS_PROBLEM_838_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_838 : public problem {
public:
    bool test() override;

    std::string pushDominoes(std::string dominoes);
};


#endif //PROBLEMS_PROBLEM_838_H