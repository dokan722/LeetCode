#ifndef PROBLEM_238_H
#define PROBLEM_238_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_238 : public problem {
public:
    bool test() override;

    std::vector<int> productExceptSelf(std::vector<int>& nums);
};



#endif //PROBLEM_238_H
