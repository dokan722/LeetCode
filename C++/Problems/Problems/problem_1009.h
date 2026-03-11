#ifndef PROBLEM_1009_H
#define PROBLEM_1009_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_1009: public problem {
public:
    bool test() override;

    int bitwiseComplement(int n);
};

#endif //PROBLEM_1009_H
