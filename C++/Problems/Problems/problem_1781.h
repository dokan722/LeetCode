#ifndef PROBLEM_1781_H
#define PROBLEM_1781_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1781 : public problem {
public:
    bool test() override;

    int beautySum(std::string s);
};

#endif //PROBLEM_1781_H
