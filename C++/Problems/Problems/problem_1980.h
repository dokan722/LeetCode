#ifndef PROBLEM_1980_H
#define PROBLEM_1980_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_1980 : public problem {
public:
    bool test() override;

    std::string findDifferentBinaryString(std::vector<std::string>& nums);
};

#endif //PROBLEM_1980_H
