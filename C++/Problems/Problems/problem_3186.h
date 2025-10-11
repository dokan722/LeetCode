#ifndef PROBLEM_3186_H
#define PROBLEM_3186_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3186 : public problem {
public:
    bool test() override;

    long long maximumTotalDamage(std::vector<int>& power);
};



#endif //PROBLEM_3186_H
