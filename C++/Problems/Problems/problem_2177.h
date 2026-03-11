#ifndef PROBLEM_2177_H
#define PROBLEM_2177_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2177: public problem {
public:
    bool test() override;

    std::vector<long long> sumOfThree(long long num);
};

#endif //PROBLEM_2177_H
