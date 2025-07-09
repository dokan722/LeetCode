#ifndef PROBLEM_1128_H
#define PROBLEM_1128_H

#include "../problem.h"
#include <vector>

class problem_1128 : public problem {
public:
    bool test() override;

    int numEquivDominoPairs(std::vector<std::vector<int>>& dominoes);
};



#endif //PROBLEM_1128_H
