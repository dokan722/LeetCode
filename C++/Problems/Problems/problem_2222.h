#ifndef PROBLEM_2222_H
#define PROBLEM_2222_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2222 : public problem {
public:
    bool test() override;

    long long numberOfWays(std::string s);
};

#endif //PROBLEM_2222_H
