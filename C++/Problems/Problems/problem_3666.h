#ifndef PROBLEM_3666_H
#define PROBLEM_3666_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3666 : public problem {
public:
    bool test() override;

    int minOperations(std::string s, int k);
};

#endif //PROBLEM_3666_H
