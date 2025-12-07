#ifndef PROBLEMS_PROBLEM_1003_H
#define PROBLEMS_PROBLEM_1003_H

#include "../problem.h"
#include <vector>
#include <string>

class problem_1003 : public problem {
public:
    bool test() override;

    bool isValid(std::string s);
};

#endif //PROBLEMS_PROBLEM_1003_H