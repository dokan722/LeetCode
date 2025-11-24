#ifndef PROBLEM_1018_H
#define PROBLEM_1018_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1018 : public problem {
public:
    bool test() override;

    std::vector<bool> prefixesDivBy5(std::vector<int>& nums);
};



#endif //PROBLEM_1018_H
