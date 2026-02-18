#ifndef PROBLEMS_PROBLEM_693_H
#define PROBLEMS_PROBLEM_693_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_693 : public problem {
public:
    bool test() override;

    bool hasAlternatingBits(int n);
};
#endif //PROBLEMS_PROBLEM_693_H