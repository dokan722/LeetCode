#ifndef PROBLEM_2437_H
#define PROBLEM_2437_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3437 : public problem {
public:
    bool test() override;

    int countTime(std::string time);
};

#endif //PROBLEM_2437_H
