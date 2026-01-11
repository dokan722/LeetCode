#ifndef PROBLEM_1663_H
#define PROBLEM_1663_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1663 : public problem {
public:
    bool test() override;

    std::string getSmallestString(int n, int k);
};

#endif //PROBLEM_1663_H
