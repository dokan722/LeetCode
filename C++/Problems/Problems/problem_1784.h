#ifndef PROBLEM_1784_H
#define PROBLEM_1784_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_1784 : public problem {
public:
    bool test() override;

    bool checkOnesSegment(std::string s);
};

#endif //PROBLEM_1784_H
