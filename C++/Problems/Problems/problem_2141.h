#ifndef PROBLEM_2141_H
#define PROBLEM_2141_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2141 : public problem {
public:
    bool test() override;

    long long maxRunTime(int n, std::vector<int>& batteries);
};

#endif //PROBLEM_2141_H
