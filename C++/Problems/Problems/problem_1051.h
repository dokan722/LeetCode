#ifndef PROBLEM_1051_H
#define PROBLEM_1051_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1051 : public problem {
public:
    bool test() override;

    int heightChecker(std::vector<int>& heights);
};



#endif //PROBLEM_1051_H
