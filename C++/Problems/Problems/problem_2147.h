#ifndef PROBLEMS_PROBLEM_2147_H
#define PROBLEMS_PROBLEM_2147_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2147 : public problem {
public:
    bool test() override;

    int numberOfWays(std::string corridor);
};

#endif //PROBLEMS_PROBLEM_2147_H