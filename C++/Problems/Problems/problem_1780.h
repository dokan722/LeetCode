#ifndef PROBLEM_1780_H
#define PROBLEM_1780_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1780 : public problem {
public:
    bool test() override;

    bool checkPowersOfThree(int n);
};

#endif //PROBLEM_1780_H
