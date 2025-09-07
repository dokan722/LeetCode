#ifndef PROBLEM_1304_H
#define PROBLEM_1304_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1304 : public problem {
public:
    bool test() override;

    std::vector<int> sumZero(int n);
};



#endif //PROBLEM_1304_H
