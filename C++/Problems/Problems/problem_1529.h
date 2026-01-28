#ifndef PROBLEM_1529_H
#define PROBLEM_1529_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1529 : public problem {
public:
    bool test() override;

    int minFlips(std::string target);
};

#endif //PROBLEM_1529_H
