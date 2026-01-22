#ifndef PROBLEM_3675_H
#define PROBLEM_3675_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3675 : public problem {
public:
    bool test() override;

    int minOperations(std::string s);
};

#endif //PROBLEM_3675_H
